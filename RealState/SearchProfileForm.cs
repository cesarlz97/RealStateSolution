using log4net;
using log4net.Util;
using RealState.Models;
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
    public partial class SearchProfileForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SQLiteManager _sqliteManager;

        private ClientSearchProfile _clientSearchProfile { get; set; }

        public SearchProfileForm(SQLiteManager sqliteManager, ClientSearchProfile clientSearchProfile)
        {
            InitializeComponent();
            this._sqliteManager = sqliteManager;
            this._clientSearchProfile = clientSearchProfile;
        }

        private void FillContent()
        {
            try
            {
                textBoxName.Text = _clientSearchProfile.Name;
                numericUpDownAreaMin.Value = _clientSearchProfile.SizeMin;
                numericUpDownPriceMax.Value = _clientSearchProfile.PriceMax;
                comboBoxBuildingRegime.SelectedValue = _clientSearchProfile.RegimeType;
                numericUpDownParkingCount.Value = _clientSearchProfile.ParkingMin;
                numericUpDownBathRoomCount.Value = _clientSearchProfile.BathroomMin;
                numericUpDownRoomMin.Value = _clientSearchProfile.RoomMin;
                checkBoxPool.Checked = _clientSearchProfile.Pool;
                dateTimePickerBuildingMaxAge.Value = _clientSearchProfile.AgeMax;
                comboBoxBuildingType.SelectedIndex = _clientSearchProfile.PropertyType;
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }

        }

        private void UpdateItem()
        {
            try
            {
                _clientSearchProfile.Name = textBoxName.Text;
                _clientSearchProfile.SizeMin = (int)numericUpDownAreaMin.Value;
                _clientSearchProfile.PriceMax = (int)numericUpDownPriceMax.Value;
                _clientSearchProfile.RegimeType = (int)comboBoxBuildingRegime.SelectedValue;
                _clientSearchProfile.ParkingMin = (int)numericUpDownParkingCount.Value;
                _clientSearchProfile.BathroomMin = (int)numericUpDownBathRoomCount.Value;
                _clientSearchProfile.RoomMin = (int)numericUpDownRoomMin.Value;
                _clientSearchProfile.Pool = checkBoxPool.Checked;
                _clientSearchProfile.AgeMax = dateTimePickerBuildingMaxAge.Value;
                _clientSearchProfile.PropertyType = (int)comboBoxBuildingType.SelectedIndex;
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private bool ValidateItem()
        {
            return textBoxName.Text.Trim() != string.Empty;
        }

        private void SearchProfileForm_Load(object sender, EventArgs e)
        {
            FillContent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateItem())
                {
                    MessageBox.Show("El campo 'Nombre' es obligatorio",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                UpdateItem();

                if (_clientSearchProfile.Id > 0)
                    _sqliteManager.UpdateData(_clientSearchProfile, new Dictionary<string, object> { { nameof(ClientSearchProfile.Id), _clientSearchProfile.Id } });
                else
                    _sqliteManager.InsertData(_clientSearchProfile);

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
