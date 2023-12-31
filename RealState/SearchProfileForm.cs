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

        private SearchProfile _searchProfile { get; set; }

        private List<Property> _propertiesMatching;

        public SearchProfileForm(SQLiteManager sqliteManager, SearchProfile clientSearchProfile)
        {
            InitializeComponent();
            this._sqliteManager = sqliteManager;
            this._searchProfile = clientSearchProfile;
        }

        private void FillContent()
        {
            try
            {
                textBoxName.Text = _searchProfile.Name;
                numericUpDownAreaMin.Value = _searchProfile.SizeMin;
                numericUpDownPriceMax.Value = _searchProfile.PriceMax;
                comboBoxBuildingRegime.SelectedIndex = _searchProfile.RegimeType;
                numericUpDownParkingCount.Value = _searchProfile.ParkingMin;
                numericUpDownBathRoomCount.Value = _searchProfile.BathroomMin;
                numericUpDownRoomMin.Value = _searchProfile.RoomMin;
                checkBoxPool.Checked = _searchProfile.Pool;
                dateTimePickerBuildingMaxAge.Value = _searchProfile.AgeMax;
                comboBoxBuildingType.SelectedIndex = _searchProfile.PropertyType;

                SearchMatchingProperties();
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
                _searchProfile.Name = textBoxName.Text;
                _searchProfile.SizeMin = (int)numericUpDownAreaMin.Value;
                _searchProfile.PriceMax = (int)numericUpDownPriceMax.Value;
                _searchProfile.RegimeType = (int)comboBoxBuildingRegime.SelectedIndex;
                _searchProfile.ParkingMin = (int)numericUpDownParkingCount.Value;
                _searchProfile.BathroomMin = (int)numericUpDownBathRoomCount.Value;
                _searchProfile.RoomMin = (int)numericUpDownRoomMin.Value;
                _searchProfile.Pool = checkBoxPool.Checked;
                _searchProfile.AgeMax = dateTimePickerBuildingMaxAge.Value;
                _searchProfile.PropertyType = (int)comboBoxBuildingType.SelectedIndex;
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

        private void SearchMatchingProperties()
        {
            Dictionary<string, object> whereClauses = new Dictionary<string, object>()
            { 
                { nameof(Property.PropertyType), _searchProfile.PropertyType },
                { nameof(Property.RegimeType), _searchProfile.RegimeType },
                { nameof(Property.DeedTime), $">={_searchProfile.AgeMax.ToString("yyyy-MM-dd HH:mm:ss")}" },
                { nameof(Property.BathroomCount), $">={_searchProfile.BathroomMin}" },
                { nameof(Property.ParkingCount), $">={_searchProfile.ParkingMin}" },
                { nameof(Property.AreaUtil), $">={_searchProfile.SizeMin}" },
                { nameof(Property.HasPool), _searchProfile.Pool },
                { nameof(Property.Price), $"<={_searchProfile.PriceMax}" },
            };

            _propertiesMatching = _sqliteManager.ReadData<Property>(limit: 100, whereClauses: whereClauses);

            listBoxPropertiesMatching.Items.Clear();
            foreach (var property in _propertiesMatching)
                listBoxPropertiesMatching.Items.Add(property.Title);
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

                if (_searchProfile.Id > 0)
                    _sqliteManager.UpdateData(_searchProfile, new Dictionary<string, object> { { nameof(SearchProfile.Id), _searchProfile.Id } });
                else
                    _sqliteManager.InsertData(_searchProfile);

                MessageBox.Show("¡Perfil de búsqueda actualizado!",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                SearchMatchingProperties();
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        void listBoxPropertiesMatching_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxPropertiesMatching.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            PropertyDetailForm propertyDetailForm = new PropertyDetailForm(_sqliteManager, _propertiesMatching[index]);
            propertyDetailForm.Closed += (s, args) =>
            {
                FillContent();
                this.Show();
            };

            this.Hide();
            propertyDetailForm.Show();
        }
    }
}
