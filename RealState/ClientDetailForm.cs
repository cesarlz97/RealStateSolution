using log4net;
using log4net.Util;
using RealState.Models;
using RealState.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
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
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxImage.Image = _client.GetProfileImage();

                textBoxClientName.Text = _client.Name;
                textBoxClientSurname.Text = _client.Surname;
                textBoxClientPhoneNumber.Text = _client.PhoneNumber;
                textBoxClientEmail.Text = _client.EmailAddress;
                pictureBoxImage.Image = _client.GetProfileImage();

                PopulateSearchProfiles();
                PopulateContracts();
                PopulateProperties();
                // Llenar listBoxContracts y listBoxSearchProfiles según la lógica de tu aplicación
                // Por ejemplo, si Client tiene una propiedad List<Contract> y una propiedad List<ClientSearchProfile>
                // entonces puedes hacer listBoxContracts.DataSource = _client.Contracts; y listBoxSearchProfiles.DataSource = _client.SearchProfiles;
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
                    _sqliteManager.InsertData(_client);

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
    }
}
