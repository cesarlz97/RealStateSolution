using log4net;
using log4net.Util;
using RealState.Forms;
using RealState.Models;
using System;
using System.Collections.Generic;
//using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace RealState
{
    public partial class PropertyDetailForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SQLiteManager _sqliteManager;

        private Property _property { get; set; }

        private List<Client> _propertyOwners { get; set; }
        private List<Client> _matchingClients { get; set; }
        private List<Contract> _propertyContracts { get; set; }

        public PropertyDetailForm(SQLiteManager sqliteManager, Property property)
        {
            InitializeComponent();
            this._property = property;
            this._sqliteManager = sqliteManager;
            this._propertyOwners = new List<Client>();
            this._matchingClients = new List<Client>();
        }

        private void FillContent()
        {
            try
            {
                pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxImage.Image = _property.GetProfileImage();

                textBoxTitle.Text = _property.Title;
                textBoxAddress.Text = _property.Address;
                numericUpDownPrice.Value = _property.Price;
                numericUpDownAreaBuilt.Value = _property.AreaBuilt;
                numericUpDownAreaUtil.Value = _property.AreaUtil;
                numericUpDownAreParcel.Value = _property.AreaPlot;
                numericUpDownKitchen.Value = _property.AreaKitchen;
                numericUpDownRoomCount.Value = _property.RoomCount;
                numericUpDownBathRoomCount.Value = _property.BathroomCount;
                numericUpDownParkingCount.Value = _property.ParkingCount;
                comboBoxRegime.SelectedIndex = _property.RegimeType;
                comboBoxType.SelectedIndex = _property.PropertyType;
                dateTimePickerAge.Value = _property.DeedTime;
                comboBoxHeatingSystem.SelectedIndex = _property.HeatingSystemType;
                checkBoxAirConditioning.Checked = _property.HasAirConditioning;
                checkBoxPool.Checked = _property.HasPool;
                richTextBoxDescription.Text = _property.Description;

                PopulatePropertyOwners();
                PopulateMatchingClients();
                PopulateContracts();
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private void PopulatePropertyOwners()
        {
            List<Client> propertyOwners = _sqliteManager.ReadData<Client>(
                joinClauses: new Dictionary<string, string>
                {
                    { "PropertyOwners", $"{nameof(Client)}s.{nameof(Client.Id)} = PropertyOwners.ClientId" }
                },
                whereClauses: new Dictionary<string, object> { { "PropertyId", _property.Id } }
            );

            listBoxPropertyOwners.Items.Clear();

            foreach (Client owner in propertyOwners)
            {
                _propertyOwners.Add(owner);
                listBoxPropertyOwners.Items.Add($"{owner.Name} {owner.Surname}");
            }
        }

        private void PopulateMatchingClients()
        {
            Dictionary<string, object> whereClauses = new Dictionary<string, object>()
            {
                { nameof(SearchProfile.PropertyType), _property.PropertyType },
                { nameof(SearchProfile.RegimeType), _property.RegimeType },
                { nameof(SearchProfile.AgeMax), $"<={_property.DeedTime.ToString("yyyy-MM-dd HH:mm:ss")}" },
                { nameof(SearchProfile.BathroomMin), $"<={_property.BathroomCount}" },
                { nameof(SearchProfile.ParkingMin), $"<={_property.ParkingCount}" },
                { nameof(SearchProfile.SizeMin), $"<={_property.AreaUtil}" },
                { nameof(SearchProfile.Pool), _property.HasPool },
                { nameof(SearchProfile.PriceMax), $">={_property.Price}" },
            };

            Dictionary<string, string> joinClauses = new Dictionary<string, string>
            {
                { "SearchProfiles", $"{_sqliteManager.GetTableName<SearchProfile>()}.{nameof(SearchProfile.ClientId)} = {_sqliteManager.GetTableName<Client>()}.{nameof(Client.Id)}" }
            };

           _matchingClients = _sqliteManager.ReadData<Client>(limit: 20, whereClauses: whereClauses, joinClauses: joinClauses);

            listBoxPotentialCustomers.Items.Clear();
            foreach (var client in _matchingClients)
                listBoxPotentialCustomers.Items.Add($"{client.Name} {client.Surname}");
        }

        private void PopulateContracts()
        {
            Dictionary<string, object> whereClauses = new Dictionary<string, object>() { { nameof(Contract.PropertyId), _property.Id } };
            _propertyContracts = _sqliteManager.ReadData<Contract>(whereClauses: whereClauses);

            listBoxContracts.Items.Clear();
            foreach (Contract propertyContract in _propertyContracts)
            {
                listBoxContracts.Items.Add(propertyContract.Name);
            }
        }

        private void UpdateItem()
        {
            try
            {
                _property.SetProfileImage(pictureBoxImage.Image);

                _property.Title = textBoxTitle.Text;
                _property.Address = textBoxAddress.Text;
                _property.Price = (int)numericUpDownPrice.Value;
                _property.AreaBuilt = (int)numericUpDownAreaBuilt.Value;
                _property.AreaUtil = (int)numericUpDownAreaUtil.Value;
                _property.AreaPlot = (int)numericUpDownAreParcel.Value;
                _property.AreaKitchen = (int)numericUpDownKitchen.Value;
                _property.RoomCount = (int)numericUpDownRoomCount.Value;
                _property.BathroomCount = (int)numericUpDownBathRoomCount.Value;
                _property.ParkingCount = (int)numericUpDownParkingCount.Value;
                _property.RegimeType = (int)comboBoxRegime.SelectedIndex;
                _property.PropertyType = (int)comboBoxType.SelectedIndex;
                _property.DeedTime = dateTimePickerAge.Value;
                _property.HeatingSystemType = (int)comboBoxHeatingSystem.SelectedIndex;
                _property.HasAirConditioning = checkBoxAirConditioning.Checked;
                _property.HasPool = checkBoxPool.Checked;
                _property.Description = richTextBoxDescription.Text;
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private bool ValidateItem()
        {
            return textBoxTitle.Text.Trim() != string.Empty && 
                textBoxAddress.Text.Trim() != string.Empty &&
                numericUpDownAreaUtil.Value > 0;
        }

        private void BuildingDetailForm_Load(object sender, EventArgs e)
        {
            FillContent();
        }

        private void buttonSaveBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateItem())
                {
                    MessageBox.Show("Los campos: 'Título', 'Dirección' y 'Área Ütil' son obligatorios",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                UpdateItem();

                if (_property.Id > 0)
                    _sqliteManager.UpdateData(_property, new Dictionary<string, object> { { nameof(Property.Id), _property.Id } });
                else
                    _sqliteManager.InsertData(_property);

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

        void listBoxPropertyOwners_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxPropertyOwners.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            ClientDetailForm clientDetailForm = new ClientDetailForm(_sqliteManager, _propertyOwners[index]);
            clientDetailForm.Closed += (s, args) =>
            {
                FillContent();
                this.Show();
            };

            this.Hide();
            clientDetailForm.Show();
        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            ItemSelectorForm<Client> propertySelector = new ItemSelectorForm<Client>(_sqliteManager);
            propertySelector.Closed += (s, args) =>
            {
                if (propertySelector.SelectedItem != null)
                {
                    List<Dictionary<string, object>> propertyOwner = new List<Dictionary<string, object>>
                    {
                        new Dictionary<string, object>
                        {
                            { "PropertyId", _property.Id },
                            { "ClientId", propertySelector.SelectedItem.Id },
                            { "PercentageOwnership", 100.0 }
                        },
                    };

                    _sqliteManager.UpsertData(propertyOwner, "PropertyOwners", new List<string> { "PropertyId", "ClientId" });

                    MessageBox.Show("¡Nuevo propietario añadido!",
                       "Información",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                    FillContent();
                }

                this.Show();
            };

            this.Hide();
            propertySelector.Show();
        }

        private void buttonDeleteOwner_Click(object sender, EventArgs e)
        {
            int index = this.listBoxPropertyOwners.SelectedIndex;
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            Client selectedOwner = _propertyOwners[index];
            if (selectedOwner == null)
                return;

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este propietario?",
                                     "Confirmar borrado",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Dictionary<string, object> entity = new Dictionary<string, object>
                {
                    { "PropertyId", _property.Id },
                    { "ClientId", selectedOwner.Id },
                    { "PercentageOwnership", 100.0 }
                };
                _sqliteManager.DeleteData(entity, "PropertyOwners", new List<string> { "PropertyId", "ClientId" });
                FillContent();
            }
        }

        private void buttonAddContract_Click(object sender, EventArgs e)
        {
            ContractForm contractForm = new ContractForm(_sqliteManager, new Contract() { PropertyId = _property.Id });
            contractForm.PropertyOwners = _propertyOwners;
            contractForm.Closed += (s, args) =>
            {
                FillContent();
                this.Show();
            };

            this.Hide();
            contractForm.Show();
        }

        private void buttonDeleteContract_Click(object sender, EventArgs e)
        {
            int index = this.listBoxContracts.SelectedIndex;
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            Contract selectedContract = _propertyContracts[index];
            if (selectedContract == null)
                return;

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este contrato?",
                                     "Confirmar borrado",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _sqliteManager.DeleteData<Contract>(selectedContract.Id);
                FillContent();
            }
        }
    }
}
