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

namespace RealState.Forms
{
    public partial class ItemSelectorForm<T> : Form where T : IListable, new()
    {
        public T SelectedItem { get; set; }
        
        public ItemSelectorForm(SQLiteManager sqliteManager)
        {
            InitializeComponent();
            SelectedItem = default(T);
            itemSelectorUserControl.Init(sqliteManager);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelectItem_Click(object sender, EventArgs e)
        {
            T currentItemSelected = this.itemSelectorUserControl.GetSelectedItem();
            if (currentItemSelected == null)
            {
                MessageBox.Show("¡Ningún elemento ha sido seleccionado!",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                return;
            }
            SelectedItem = currentItemSelected;
            this.Close();
        }

    }
}
