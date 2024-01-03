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

namespace RealState
{
    public partial class ItemSelectorForm<T> : Form where T : IListable, new()
    {
        public T SelectedItem { get { return this.itemSelectorUserControl.GetSelectedItem(); } }
        
        public ItemSelectorForm(SQLiteManager sqliteManager)
        {
            InitializeComponent();
            itemSelectorUserControl.Init(sqliteManager);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelectItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
            {
                MessageBox.Show("¡Ningún elemento ha sido seleccionado!",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                return;
            }

            this.Close();
        }

    }
}
