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

        private List<Client> _propertySellers;
        private List<Client> _propertyBuyers;

        public List<Client> PropertyOwners { private get; set; }

        public ContractForm(SQLiteManager sqliteManager, Contract contract)
        {
            InitializeComponent();
            _sqliteManager = sqliteManager;
            _contract = contract;
        }

        private void FillContent()
        {
            if (_contract.Id > 0)
            {
                LoadSellers();
                LoadBuyers();
            }
            else
            {
                SetOwnersAsSellers();
            }
        }

        private void LoadSellers()
        {

        }

        private void LoadBuyers()
        {

        }

        private void SetOwnersAsSellers()
        {

        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            FillContent();
        }

        private void buttonSelectProperty_Click(object sender, EventArgs e)
        {
            ItemSelectorForm<Property> propertySelector = new ItemSelectorForm<Property>(_sqliteManager);
            propertySelector.Closed += (s, args) =>
            {
                if (propertySelector.SelectedItem != null)
                {
                    textBoxPropertyTitle.Text = propertySelector.SelectedItem.Title;
                    _contract.PropertyId = propertySelector.SelectedItem.Id;
                }

                this.Show();
            };

            this.Hide();
            propertySelector.Show();
        }

        private void comboBoxContractType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddSeller_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSeller_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBuyer_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBuyer_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

    }
}
