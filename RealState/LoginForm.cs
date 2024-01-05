using log4net;
using RealState.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    public partial class LoginForm : Form
    {
        private enum LoginFormMode
        {
            LoginMode,
            RegisterMode,

        }

        private LoginFormMode mode = LoginFormMode.LoginMode;

        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SQLiteManager _sqliteManager;

        private User _user;

        public LoginForm(SQLiteManager sqliteManager)
        {
            InitializeComponent();
            _sqliteManager = sqliteManager;
            _user = null;
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mode == LoginFormMode.LoginMode)
            {
                this.labelPasswordConfirm.Visible = true;
                this.textBoxPasswordConfirm.Visible = true;

                this.buttonLoginRegister.Text = "Registrarse";
                this.linkLabelRegister.Text = "Volver a login";

                this.mode = LoginFormMode.RegisterMode;
            }
            else
            {
                this.labelPasswordConfirm.Visible = false;
                this.textBoxPasswordConfirm.Visible = false;

                this.buttonLoginRegister.Text = "Entrar";
                this.linkLabelRegister.Text = "Registrarse";

                this.mode = LoginFormMode.LoginMode;
            }
        }

        private void buttonLoginRegister_Click(object sender, EventArgs e)
        {
            if (mode == LoginFormMode.RegisterMode)
            {
                // Registro de usuario
                bool success = RegisterUser();
            }
            else
            {
                // Inicio de sesión
                if (LoginUser())
                {
                    MainForm mainForm = new MainForm(_sqliteManager, _user);
                    mainForm.Closed += (s, args) => this.Close();

                    this.Hide();
                    mainForm.Show();
                }
            }
        }

        private bool RegisterUser()
        {
            try
            {
                string userName = textBoxUser.Text;
                string password = textBoxPassword.Text;
                string passwordConfirm = textBoxPasswordConfirm.Text;

                // Verificar que las contraseñas coincidan
                if (password != passwordConfirm)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Calcular el hash de la contraseña
                string passwordHash = CalculatePasswordHash(password);

                // Verificar si el usuario ya existe
                Dictionary<string, object> existingUserCheck = new Dictionary<string, object>
                {
                    { nameof(User.UserName), userName }
                };

                List<User> existingUsers = _sqliteManager.ReadData<User>(whereClauses: existingUserCheck);

                if (existingUsers.Count > 0)
                {
                    MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Crear un nuevo usuario
                User newUser = new User(userName, passwordHash);

                // Insertar el nuevo usuario en la base de datos
                _sqliteManager.InsertData(newUser);

                MessageBox.Show("Usuario registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                Log.Error("Error al registrar usuario", ex);
                return false;
            }
        }


        private bool LoginUser()
        {
            bool success = false;

            try
            {
                string userName = textBoxUser.Text;
                string password = textBoxPassword.Text;

                // Calcular el hash de la contraseña ingresada
                string passwordHash = CalculatePasswordHash(password);

                // Consultar la base de datos para encontrar al usuario
                Dictionary<string, object> whereClauses = new Dictionary<string, object>
                {
                    { "UserName", userName },
                    { "PasswordHash", passwordHash }
                };

                List<User> users = _sqliteManager.ReadData<User>(whereClauses: whereClauses);

                if (users.Count > 0)
                {
                    //MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _user = users.First();
                    success = true;
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Error al identificar usuario", ex);
            }

            return success;
        }

        private string CalculatePasswordHash(string password)
        {
            // El mismo método utilizado en la clase User
            byte[] tmpSource = Encoding.ASCII.GetBytes(password);
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            return Convert.ToBase64String(tmpHash);
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
#if DEBUG
            MainForm mainForm = new MainForm(_sqliteManager, new User() { Id = 1 });
            mainForm.Closed += (s, args) => this.Close();

            this.Hide();
            mainForm.Show();
#endif
        }
    }
}
