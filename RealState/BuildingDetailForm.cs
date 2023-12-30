using log4net;
using log4net.Util;
using RealState.Models;
using RealState.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    public partial class BuildingDetailForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SQLiteManager _sqliteManager;

        private Property _property { get; set; }

        private List<Client> _propertyOwners { get; set; }

        public BuildingDetailForm(SQLiteManager sqliteManager, Property property)
        {
            InitializeComponent();
            this._property = property;
            this._sqliteManager = sqliteManager;
            this._propertyOwners = new List<Client>();
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

                LoadPropertyOwners();
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private void LoadPropertyOwners()
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
    }
}
