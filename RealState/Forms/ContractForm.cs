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

namespace RealState.Forms
{
    public partial class ContractForm : Form
    {
        private enum ContractFormMode
        {
            Rent,
            Buy,

        }

        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ContractFormMode _contractFormMode;

        private SQLiteManager _sqliteManager;
        private Contract _contract;

        private Property _property;

        private List<Client> _propertySellers;
        private List<Client> _propertyBuyers;

        public void SetProperty(Property property)
        {
            _property = property;
        }

        public void SetContractSellers(List<Client> propertySellers)
        {
            _propertySellers = propertySellers;
        }

        public ContractForm(SQLiteManager sqliteManager, Contract contract)
        {
            InitializeComponent();
            _contractFormMode = ContractFormMode.Rent;
            _sqliteManager = sqliteManager;
            _contract = contract;
            _property = null;
            _propertySellers = new List<Client>();
            _propertyBuyers = new List<Client>();
        }

        private void FillContent()
        {
            try
            {
                if (_property == null)
                    _property = _sqliteManager.ReadData<Property>(whereClauses: new Dictionary<string, object> { { nameof(Property.Id), _contract.PropertyId } }).FirstOrDefault();

                textBoxName.Text = _contract.Name;
                textBoxPropertyTitle.Text = _property.Title;
                comboBoxContractType.SelectedIndex = _contract.ContractType;
                dateTimePickerSignatureDate.Value = _contract.SignatureDate;
                numericUpDownAmount.Value = _contract.Amount;

                if (_contract.Id > 0)
                {
                    LoadSellers();
                    LoadBuyers();
                }

                PopulateSellers();
                PopulateBuyers();
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private void LoadSellers()
        {
            _propertySellers = _sqliteManager.ReadData<Client>(
                joinClauses: new Dictionary<string, string>
                {
                    { "SellersSoldPercentage", $"SellersSoldPercentage.ClientId = {_sqliteManager.GetTableName<Client>()}.{nameof(Client.Id)}" }
                },
                whereClauses: new Dictionary<string, object> { { "ContractId", _contract.Id } }
            );
        }

        private void LoadBuyers()
        {
            _propertyBuyers = _sqliteManager.ReadData<Client>(
                joinClauses: new Dictionary<string, string>
                {
                    { "BuyersBoughtPercentage", $"BuyersBoughtPercentage.ClientId = {_sqliteManager.GetTableName<Client>()}.{nameof(Client.Id)}" }
                },
                whereClauses: new Dictionary<string, object> { { "ContractId", _contract.Id } }
            );
        }

        private void PopulateSellers()
        {
            listBoxSellers.Items.Clear();
            foreach (Client seller in _propertySellers)
                listBoxSellers.Items.Add($"{seller.Name} {seller.Surname}");
        }

        private void PopulateBuyers()
        {
            listBoxBuyers.Items.Clear();
            foreach (Client buyer in _propertyBuyers)
                listBoxBuyers.Items.Add($"{buyer.Name} {buyer.Surname}");
        }

        private bool ValidateItem()
        {
            return textBoxName.Text.Trim() != string.Empty &&
                numericUpDownAmount.Value > 0 &&
                _propertySellers.Count > 0 &&
                _propertyBuyers.Count > 0;
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
                FillContent();
                this.Show();
            };

            this.Hide();
            propertySelector.Show();
        }

        private void comboBoxContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxContractType.SelectedIndex;
            if (index == (int)ContractFormMode.Rent)
            {
                _contractFormMode = ContractFormMode.Rent;
                labelSellers.Text = "Arrendadores";
                labelBuyers.Text = "Arrendatarios";
                labelEuros.Text = "€/mes";
            }
            else if (index == (int)ContractFormMode.Buy)
            {
                _contractFormMode = ContractFormMode.Buy;
                labelSellers.Text = "Vendedores";
                labelBuyers.Text = "Compradores";
                labelEuros.Text = "€";
            }
        }

        private void buttonAddSeller_Click(object sender, EventArgs e)
        {
            ItemSelectorForm<Client> clientSelector = new ItemSelectorForm<Client>(_sqliteManager);
            clientSelector.Closed += (s, args) =>
            {
                if (clientSelector.SelectedItem != null)
                {
                    if (_propertySellers.Any(item => item.Id == clientSelector.SelectedItem.Id))
                    {
                        MessageBox.Show("¡El vendedor seleccionado ya existe en este contrato!",
                       "Alerta",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _propertySellers.Add(clientSelector.SelectedItem);

                        MessageBox.Show("¡Nuevo vendedor añadido!",
                       "Información",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                        //FillContent();
                        PopulateSellers();
                        PopulateBuyers();
                    }
                }

                this.Show();
            };

            this.Hide();
            clientSelector.Show();
        }

        private void buttonDeleteSeller_Click(object sender, EventArgs e)
        {
            int index = this.listBoxSellers.SelectedIndex;
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            Client selectedSeller = _propertySellers[index];
            if (selectedSeller == null)
                return;

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este vendedor/arrendador?",
                                     "Confirmar borrado",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _sqliteManager.DeleteData<Contract>(selectedSeller.Id);
                _propertySellers.RemoveAt(index);
                //FillContent();
                PopulateSellers();
                PopulateBuyers();
            }
        }

        private void buttonAddBuyer_Click(object sender, EventArgs e)
        {
            ItemSelectorForm<Client> clientSelector = new ItemSelectorForm<Client>(_sqliteManager);
            clientSelector.Closed += (s, args) =>
            {
                if (clientSelector.SelectedItem != null)
                {
                    if (_propertyBuyers.Any(item => item.Id == clientSelector.SelectedItem.Id))
                    {
                        MessageBox.Show("¡El comprador seleccionado ya existe en este contrato!",
                       "Alerta",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _propertyBuyers.Add(clientSelector.SelectedItem);

                        MessageBox.Show("¡Nuevo comprador añadido!",
                       "Información",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                        //FillContent();
                        PopulateSellers();
                        PopulateBuyers();
                    }
                }

                this.Show();
            };

            this.Hide();
            clientSelector.Show();
        }

        private void buttonDeleteBuyer_Click(object sender, EventArgs e)
        {
            int index = this.listBoxBuyers.SelectedIndex;
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            Client selectedBuyer = _propertyBuyers[index];
            if (selectedBuyer == null)
                return;

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este comprador/arrendatario?",
                                     "Confirmar borrado",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _sqliteManager.DeleteData<Contract>(selectedBuyer.Id);
                _propertyBuyers.RemoveAt(index);
                //FillContent();
                PopulateSellers();
                PopulateBuyers();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateItem())
                {
                    MessageBox.Show("Los campos: 'Nombre', 'Precio', 'Vendedores/Arrendadores' y 'Compradores/Arrendatarios' son obligatorios",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                UpdateItem();
                SaveContract();
                SaveSellers();
                SaveBuyers();

                MessageBox.Show("¡Contrato actualizado en la base de datos!",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private void UpdateItem()
        {
            _contract.PropertyId = _property.Id;
            _contract.Name = textBoxName.Text.Trim();
            _contract.ContractType = (int)_contractFormMode;
            _contract.Amount = (int)numericUpDownAmount.Value;
            _contract.SignatureDate = dateTimePickerSignatureDate.Value;
        }

        private void SaveContract()
        {
            if (_contract.Id > 0)
                _sqliteManager.UpdateData(_contract, new Dictionary<string, object> { { nameof(Contract.Id), _contract.Id } });
            else
                _contract.Id = Convert.ToInt32(_sqliteManager.InsertData(_contract));
        }

        private void SaveSellers()
        {
            foreach (Client seller in _propertySellers)
            {
                List<Dictionary<string, object>> propertySeller = new List<Dictionary<string, object>>
                    {
                        new Dictionary<string, object>
                        {
                            { "ContractId", _contract.Id },
                            { "ClientId", seller.Id },
                            { "Percentage", 100.0 }
                        },
                    };

                _sqliteManager.UpsertData(propertySeller, "SellersSoldPercentage", new List<string> { "ContractId", "ClientId" });
            }
        }

        private void SaveBuyers()
        {
            foreach (Client seller in _propertyBuyers)
            {
                List<Dictionary<string, object>> propertyBuyer = new List<Dictionary<string, object>>
                    {
                        new Dictionary<string, object>
                        {
                            { "ContractId", _contract.Id },
                            { "ClientId", seller.Id },
                            { "Percentage", 100.0 }
                        },
                    };

                _sqliteManager.UpsertData(propertyBuyer, "BuyersBoughtPercentage", new List<string> { "ContractId", "ClientId" });
            }
        }

    }
}
