using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;

public class SQLiteManager
{
    private string _connectionString;

    public SQLiteManager(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void CreateDatabase<T>()
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            CreateTable<T>(connection);
        }
    }

    public void InsertData<T>(T entity)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(BuildInsertQuery<T>(), connection))
            {
                AddParameters(command, entity);
                command.ExecuteNonQuery();
            }
        }
    }

    public void InsertData<T>(List<T> entities)
    {
        if (entities == null || entities.Count == 0)
        {
            // No hay datos para insertar
            return;
        }

        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();

            foreach (T entity in entities)
            {
                using (SQLiteCommand command = new SQLiteCommand(BuildInsertQuery<T>(), connection))
                {
                    AddParameters(command, entity);
                    command.ExecuteNonQuery();
                }
            }
        }
    }


    //public DataTable ReadData<T>(string tableName, Dictionary<string, object> whereClauses = null)
    //{
    //    DataTable dataTable = new DataTable();
    //    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
    //    {
    //        connection.Open();
    //        using (SQLiteCommand command = new SQLiteCommand(BuildSelectQuery<T>(tableName, whereClauses), connection))
    //        {
    //            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
    //            {
    //                adapter.Fill(dataTable);
    //            }
    //        }
    //    }
    //    return dataTable;
    //}

    //public List<T> ReadData<T>(Dictionary<string, object> whereClauses = null)
    //{
    //    List<T> result = new List<T>();

    //    using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
    //    {
    //        connection.Open();
    //        using (SQLiteCommand command = new SQLiteCommand(BuildSelectQuery<T>(whereClauses), connection))
    //        {
    //            AddWhereParameters(command, whereClauses);

    //            using (SQLiteDataReader reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    T entity = MapDataReaderToEntity<T>(reader);
    //                    result.Add(entity);
    //                }
    //            }
    //        }
    //    }

    //    return result;
    //}

    public List<T> ReadData<T>(int? limit = null, int? offset = null, Dictionary<string, object> whereClauses = null, Dictionary<string, string> joinClauses = null)
    {
        List<T> result = new List<T>();

        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(BuildSelectQuery<T>(whereClauses, joinClauses), connection))
            {
                AddWhereParameters(command, whereClauses);
                AddJoinClauses(command, joinClauses);

                // Agregar cláusulas de paginación si se especifican
                if (limit.HasValue)
                {
                    command.CommandText += $" LIMIT {limit.Value}";

                    if (offset.HasValue)
                    {
                        command.CommandText += $" OFFSET {offset.Value}";
                    }
                }

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T entity = MapDataReaderToEntity<T>(reader);
                        result.Add(entity);
                    }
                }
            }
        }

        return result;
    }

    private string BuildSelectQuery<T>(Dictionary<string, object> whereClauses, Dictionary<string, string> joinClauses)
    {
        string query = $"SELECT * FROM {GetTableName<T>()}";

        if (joinClauses != null && joinClauses.Any())
        {
            foreach (var joinClause in joinClauses)
            {
                query += $" JOIN {joinClause.Key} ON {joinClause.Value}";
            }
        }

        if (whereClauses != null && whereClauses.Any())
        {
            query += " WHERE " + string.Join(" AND ", whereClauses.Select(kv => $"{kv.Key} = @{kv.Key}"));
        }

        return query;
    }

    private void AddJoinClauses(SQLiteCommand command, Dictionary<string, string> joinClauses)
    {
        if (joinClauses != null)
        {
            foreach (var joinClause in joinClauses)
            {
                command.CommandText += $" JOIN {joinClause.Key} ON {joinClause.Value}";
            }
        }
    }

    private T MapDataReaderToEntity<T>(SQLiteDataReader reader)
    {
        T entity = Activator.CreateInstance<T>();

        PropertyInfo[] properties = typeof(T).GetProperties();
        foreach (PropertyInfo property in properties)
        {
            string propertyName = property.Name;
            if (ColumnExists(reader, propertyName) && !reader.IsDBNull(reader.GetOrdinal(propertyName)))
            {
                Type propertyType = property.PropertyType;
                object value = reader[propertyName];

                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    propertyType = Nullable.GetUnderlyingType(propertyType);
                }

                property.SetValue(entity, Convert.ChangeType(value, propertyType));
            }
        }

        return entity;
    }

    private bool ColumnExists(SQLiteDataReader reader, string columnName)
    {
        DataTable schemaTable = reader.GetSchemaTable();
        return schemaTable != null && schemaTable.Select($"ColumnName = '{columnName}'").Length > 0;
    }

    public void UpdateData<T>(T entity, Dictionary<string, object> whereClauses)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(BuildUpdateQuery<T>(whereClauses), connection))
            {
                AddParameters(command, entity);
                AddWhereParameters(command, whereClauses);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteData<T>(int id, string tableName)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand($"DELETE FROM {tableName} WHERE Id = @Id;", connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }

    private void CreateTable<T>(SQLiteConnection connection)
    {
        using (SQLiteCommand command = new SQLiteCommand(BuildCreateTableQuery<T>(), connection))
        {
            command.ExecuteNonQuery();
        }
    }

    private string GetTableName<T>()
    {
        return typeof(T).Name + "s"; // Assuming table names are pluralized class names
    }

    private string BuildCreateTableQuery<T>()
    {
        PropertyInfo[] properties = typeof(T).GetProperties();

        List<string> columns = new List<string>();
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            string columnType = GetSQLiteType(property.PropertyType);
            string columnDefinition = $"{columnName} {columnType}";
            columns.Add(columnDefinition);
        }

        string query = $"CREATE TABLE IF NOT EXISTS {GetTableName<T>()} ({string.Join(", ", columns)});";
        return query;
    }

    private string BuildInsertQuery<T>()
    {
        PropertyInfo[] properties = typeof(T).GetProperties();

        List<string> columns = new List<string>();
        List<string> values = new List<string>();
        foreach (PropertyInfo property in properties.Where(prop => prop.Name != "Id"))
        {
            string columnName = property.Name;
            columns.Add(columnName);
            values.Add($"@{columnName}");
        }

        string query = $"INSERT INTO {GetTableName<T>()} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)});";
        return query;
    }

    private string BuildSelectQuery<T>(Dictionary<string, object> whereClauses)
    {
        string query = $"SELECT * FROM {GetTableName<T>()}";
        if (whereClauses != null && whereClauses.Any())
        {
            query += " WHERE " + string.Join(" AND ", whereClauses.Select(kv => $"{kv.Key} = @{kv.Key}"));
        }
        return query;
    }

    private string BuildUpdateQuery<T>(Dictionary<string, object> whereClauses)
    {
        PropertyInfo[] properties = typeof(T).GetProperties();

        List<string> setClauses = new List<string>();
        foreach (PropertyInfo property in properties)
        {
            string columnName = property.Name;
            setClauses.Add($"{columnName} = @{columnName}");
        }

        string query = $"UPDATE {GetTableName<T>()} SET {string.Join(", ", setClauses)}";
        if (whereClauses != null && whereClauses.Any())
        {
            query += " WHERE " + string.Join(" AND ", whereClauses.Select(kv => $"{kv.Key} = @{kv.Key}"));
        }
        return query;
    }

    private void AddParameters<T>(SQLiteCommand command, T entity)
    {
        PropertyInfo[] properties = typeof(T).GetProperties();
        foreach (PropertyInfo property in properties.Where(prop => prop.Name != "Id"))
        {
            string paramName = "@" + property.Name;
            object value = property.GetValue(entity);
            command.Parameters.AddWithValue(paramName, value ?? DBNull.Value);
        }
    }

    private void AddWhereParameters(SQLiteCommand command, Dictionary<string, object> whereClauses)
    {
        if (whereClauses != null)
        {
            foreach (var clause in whereClauses)
            {
                string paramName = "@" + clause.Key;
                command.Parameters.AddWithValue(paramName, clause.Value ?? DBNull.Value);
            }
        }
    }

    private string GetSQLiteType(Type type)
    {
        if (type == typeof(int))
        {
            return "INTEGER";
        }
        else if (type == typeof(string))
        {
            return "TEXT";
        }
        else if (type == typeof(decimal))
        {
            return "DECIMAL";
        }
        // Add more type mappings as needed

        throw new NotSupportedException($"Type {type} is not supported in SQLiteManager.");
    }
}
