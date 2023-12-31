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
    public partial class PropertySelectorForm : Form
    {
        public Property SelectedProperty { get { return this.propertySelectorUserControl.GetSelectedItem(); } }
        
        public PropertySelectorForm(SQLiteManager sqliteManager)
        {
            InitializeComponent();
            propertySelectorUserControl.Init(sqliteManager);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelectProperty_Click(object sender, EventArgs e)
        {
            if (SelectedProperty == null)
            {
                MessageBox.Show("Ninguna propiedad ha sido seleccionada",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                return;
            }

            this.Close();
        }

    }
}
