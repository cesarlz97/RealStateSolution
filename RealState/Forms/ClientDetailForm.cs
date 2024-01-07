using log4net;
using log4net.Util;
using RealState.CustomControls;
using RealState.Forms;
using RealState.Models;
using RealState.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState.Forms
{
    public partial class ClientDetailForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SQLiteManager _sqliteManager;

        private Client _client { get; set; }
        private List<SearchProfile> _clientSearchProfiles { get; set; }
        private List<Contract> _clientContracts { get; set; }
        private List<Property> _clientProperties { get; set; }

        public ClientDetailForm(SQLiteManager sqliteManager, Client client)
        {
            InitializeComponent();
            _sqliteManager = sqliteManager;
            _client = client;
        }

        private void FillContent()
        {
            try
            {
                Image profileImage = _client.GetProfileImage();
                if (profileImage != null) pictureBoxImage.Image = profileImage;

                textBoxClientName.Text = _client.Name;
                textBoxClientSurname.Text = _client.Surname;
                textBoxClientPhoneNumber.Text = _client.PhoneNumber;
                textBoxClientEmail.Text = _client.EmailAddress;

                PopulateSearchProfiles();
                PopulateContracts();
                PopulateProperties();
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private void PopulateSearchProfiles()
        {
            Dictionary<string, object> whereClauses = new Dictionary<string, object>() { { nameof(SearchProfile.ClientId), _client.Id } };
            _clientSearchProfiles = _sqliteManager.ReadData<SearchProfile>(whereClauses: whereClauses);

            listBoxSearchProfiles.Items.Clear();
            foreach (SearchProfile clientSearchProfile in _clientSearchProfiles)
            {
                listBoxSearchProfiles.Items.Add(clientSearchProfile.Name);
            }
        }

        private void PopulateContracts()
        {
            List<Contract> contractsAsBuyer = _sqliteManager.ReadData<Contract>(
                joinClauses: new Dictionary<string, string>
                {
                    { "BuyersBoughtPercentage", $"{_sqliteManager.GetTableName<Contract>()}.{nameof(Contract.Id)} = BuyersBoughtPercentage.ContractId" }
                },
                whereClauses: new Dictionary<string, object> { { "ClientId", _client.Id } }
            );

            List<Contract> contractsAsSeller = _sqliteManager.ReadData<Contract>(
                joinClauses: new Dictionary<string, string>
                {
                    { "SellersSoldPercentage", $"{_sqliteManager.GetTableName<Contract>()}.{nameof(Contract.Id)} = SellersSoldPercentage.ContractId" }
                },
                whereClauses: new Dictionary<string, object> { { "ClientId", _client.Id } }
            );

            _clientContracts = new List<Contract>();
            listBoxContracts.Items.Clear();

            foreach (Contract contract in contractsAsBuyer)
            {
                _clientContracts.Add(contract);
                listBoxContracts.Items.Add(string.Format("{0} - {1}", contract.ContractType == 0 ? "Comprador" : "Arrendatario", contract.Name));
            }

            foreach (Contract contract in contractsAsSeller)
            {
                _clientContracts.Add(contract);
                listBoxContracts.Items.Add(string.Format("{0} - {1}", contract.ContractType == 0 ? "Vendedor" : "Arrendador", contract.Name));
            }

        }

        private void PopulateProperties()
        {
            _clientProperties = _sqliteManager.ReadData<Property>(
                joinClauses: new Dictionary<string, string>
                {
                    { "PropertyOwners", $"{_sqliteManager.GetTableName<Property>()}.{nameof(Property.Id)} = PropertyOwners.PropertyId" }
                },
                whereClauses: new Dictionary<string, object> { { "ClientId", _client.Id } }
            );

            listBoxProperties.Items.Clear();

            foreach (Property property in _clientProperties)
            {
                listBoxProperties.Items.Add(property.Title);
            }

        }

        private void UpdateItem()
        {
            try
            {
                _client.SetProfileImage(pictureBoxImage.Image);

                _client.Name = textBoxClientName.Text;
                _client.Surname = textBoxClientSurname.Text;
                _client.PhoneNumber = textBoxClientPhoneNumber.Text;
                _client.EmailAddress = textBoxClientEmail.Text;
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private bool ValidateItem()
        {
            return textBoxClientName.Text.Trim() != string.Empty &&
                textBoxClientSurname.Text.Trim() != string.Empty &&
                textBoxClientPhoneNumber.Text.Trim() != string.Empty &&
                textBoxClientEmail.Text.Trim() != string.Empty;
        }

        private void ClientDetailForm_Load(object sender, EventArgs e)
        {
            FillContent();
        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateItem())
                {
                    MessageBox.Show("Los campos: 'Nombre', 'Apellidos', 'Telf.' e 'Email' son obligatorios",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                UpdateItem();

                if (_client.Id > 0)
                    _sqliteManager.UpdateData(_client, new Dictionary<string, object> { { nameof(Client.Id), _client.Id } });
                else
                    _client.Id = Convert.ToInt32(_sqliteManager.InsertData(_client));

                MessageBox.Show("¡Propiedad actualizada en la base de datos!",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        void listBoxSearchProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxSearchProfiles.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            SearchProfileForm searchProfileForm = new SearchProfileForm(_sqliteManager, _clientSearchProfiles[index]);
            searchProfileForm.Closed += (s, args) =>
            {
                FillContent();
                this.Show();
            };

            this.Hide();
            searchProfileForm.Show();
        }

        void listBoxProperties_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxProperties.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            PropertyDetailForm propertyDetailForm = new PropertyDetailForm(_sqliteManager, _clientProperties[index]);
            propertyDetailForm.Closed += (s, args) =>
            {
                FillContent();
                this.Show();
            };

            this.Hide();
            propertyDetailForm.Show();
        }

        void listBoxContracts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxContracts.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            ContractForm contractForm = new ContractForm(_sqliteManager, _clientContracts[index]);
            contractForm.Closed += (s, args) =>
            {
                FillContent();
                this.Show();
            };

            this.Hide();
            contractForm.Show();
        }

        private void buttonAddSearchProfile_Click(object sender, EventArgs e)
        {
            SearchProfileForm searchProfileForm = new SearchProfileForm(_sqliteManager, new SearchProfile() { ClientId = _client.Id });
            searchProfileForm.Closed += (s, args) =>
            {
                FillContent();
                this.Show();
            };

            this.Hide();
            searchProfileForm.Show();
        }

        private void buttonDeleteSearchProfile_Click(object sender, EventArgs e)
        {
            int index = this.listBoxSearchProfiles.SelectedIndex;
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            SearchProfile selectedSearcProfile = _clientSearchProfiles[index];
            if (selectedSearcProfile == null)
                return;

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este perfil de búsqueda?",
                                     "Confirmar borrado",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _sqliteManager.DeleteData<SearchProfile>(selectedSearcProfile.Id);
                FillContent();
            }
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            // Configurar el OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar Imagen";

            // Mostrar el cuadro de diálogo
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si el usuario seleccionó un archivo
            if (result == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                try
                {
                    // Cargar la imagen en el control de imagen
                    Image imagenSeleccionada = Image.FromFile(filePath);
                    pictureBoxImage.Image = imagenSeleccionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.ErrorExt(ex);
                }
            }
        }
    }
}
