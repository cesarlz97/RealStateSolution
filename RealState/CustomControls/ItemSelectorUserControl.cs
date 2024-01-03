using RealState.Models;
using RealState.Models.Interfaces;
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
    public partial class ItemSelectorUserControl<T> : UserControl where T : IListable, new()
    {
        private int _count = 0;
        private int _offset = 0;
        private int _limit = 10;

        private SQLiteManager _sqliteManager;
        private List<T> _items;

        public ItemSelectorUserControl()
        {
            InitializeComponent();
        }

        public void Init(SQLiteManager sqliteManager)
        {
            _sqliteManager = sqliteManager;

            LoadItems();
        }

        public T GetSelectedItem()
        {
            if (exListBoxUserControl.SelectedIndex == -1)
                return default;

            //return _items.Find(item => item.Id == ((ExListBoxItem)exListBoxUserControl.SelectedItem).Id);
            return _items[exListBoxUserControl.SelectedIndex];
        }

        private void UpdateItemsCount()
        {
            Dictionary<string, object> whereClauses = null;
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
                whereClauses = new Dictionary<string, object>
                {
                    { (new T()).GetSearchFieldName() , $"%{textBoxSearch.Text.Trim()}%" }
                };

            _count = _sqliteManager.CountRecords<T>(whereClauses: whereClauses);
        }

        private void LoadItems()
        {
            UpdateItemsCount();

            Dictionary<string, object> whereClauses = null;
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
                whereClauses = new Dictionary<string, object>
                {
                    {  (new T()).GetSearchFieldName(), $"%{textBoxSearch.Text.Trim()}%" }
                };

            _items = _sqliteManager.ReadData<T>(limit: _limit, offset: _offset, whereClauses);

            FillContent();
        }

        public void FillContent()
        {
            this.exListBoxUserControl.Items.Clear();
            foreach (T item in _items)
                this.exListBoxUserControl.Items.Add(new ExListBoxItem(item.GetId(), item.GetTitle(), item.GetGetails(), item.GetProfileImage()));

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
