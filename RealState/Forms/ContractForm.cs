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

namespace RealState.Forms
{
    public partial class ContractForm : Form
    {
        private SQLiteManager _sqliteManager;
        private Contract _contract;
        
        public ContractForm(SQLiteManager sqliteManager, Contract contract)
        {
            InitializeComponent();
            _sqliteManager = sqliteManager;
            _contract = contract;
        }

        private void buttonSelectProperty_Click(object sender, EventArgs e)
        {
            PropertySelectorForm propertySelector = new PropertySelectorForm(_sqliteManager);
            propertySelector.Closed += (s, args) =>
            {
                if (propertySelector.SelectedProperty != null)
                {
                    textBoxPropertyTitle.Text = propertySelector.SelectedProperty.Title;
                    _contract.PropertyId = propertySelector.SelectedProperty.Id;
                }

                this.Show();
            };

            this.Hide();
            propertySelector.Show();
        }
    }
}
