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

namespace RealState.CustomControls
{
    public partial class PropertySelectorUserControl : UserControl
    {
        private int _count = 0;
        private int _offset = 0;
        private int _limit = 10;

        private SQLiteManager _sqliteManager;
        private List<Property> _items;

        public PropertySelectorUserControl()
        {
            InitializeComponent();
        }

        public void Init(SQLiteManager sqliteManager)
        {
            _sqliteManager = sqliteManager;

            LoadItems();
        }

        public Property GetSelectedItem()
        {
            if (exListBoxUserControl.SelectedIndex == -1)
                return null;

            //return _items.Find(item => item.Id == ((ExListBoxItem)exListBoxUserControl.SelectedItem).Id);
            return _items[exListBoxUserControl.SelectedIndex];
        }

        private void UpdateItemsCount()
        {
            Dictionary<string, object> whereClauses = null;
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
                whereClauses = new Dictionary<string, object>
                {
                    { nameof(Property.Title), $"%{textBoxSearch.Text.Trim()}%" }
                };

            _count = _sqliteManager.CountRecords<Property>(whereClauses: whereClauses);
        }

        private void LoadItems()
        {
            UpdateItemsCount();

            Dictionary<string, object> whereClauses = null;
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
                whereClauses = new Dictionary<string, object>
                {
                    { nameof(Property.Title), $"%{textBoxSearch.Text.Trim()}%" }
                };

            _items = _sqliteManager.ReadData<Property>(limit: _limit, offset: _offset, whereClauses);

            FillContent();
        }

        public void FillContent()
        {
            this.exListBoxUserControl.Items.Clear();
            foreach (var item in _items)
            {
                string details = string.Format(
                    "Antiguedad: {0} años \n" +
                    "Superficie: {1} m2 \n" +
                    "Precio: {2} €",
                    item.GetAge(),
                    item.AreaUtil,
                    item.Price);

                this.exListBoxUserControl.Items.Add(new ExListBoxItem(item.Id, item.Title, details, item.GetProfileImage()));
            }

            labelPagination.Text = $"{_offset + 1} - {_offset + _limit} de {_count}";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            _offset = 0;
            _limit = 10;
            LoadItems();
        }

        private void buttonPaginationNext_Click(object sender, EventArgs e)
        {
            if (_count <= _offset + 10) return;
            _offset = _offset + 10;
            LoadItems();
        }

        private void buttonPaginationPrevious_Click(object sender, EventArgs e)
        {
            if (_offset ==  0) return;
            _offset = _offset - 10;
        }
    }
}
