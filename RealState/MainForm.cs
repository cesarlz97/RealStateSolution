using log4net;
using RealState.CustomControls;
using RealState.Models;
using RealState.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    public partial class MainForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SQLiteManager _sqliteManager;

        public MainForm(SQLiteManager sqliteManager)
        {
            InitializeComponent();

            _sqliteManager = sqliteManager;

            //GenerateTestProperties();
            //GenerateTestClients();
            //GeneratePropertyOwners();
            //GenerateTestSearchProfiles();
        }

        private void GenerateTestProperties()
        {
            List<Property> propertyList = new List<Property>();

            Property property = new Property()
            {
                Id = 1,
                Address = "Calle Mayor 12",
                AreaBuilt = 120,
                AreaKitchen = 18,
                AreaPlot = 300,
                AreaUtil = 110,
                BathroomCount = 2,
                DeedTime = new DateTime(1980,1,1),
                Description = "Acogedora casa recién reformada en el centro. Cuenta con jardín, piscina y porche",
                HasAirConditioning = true,
                HasPool = true,
                HeatingSystemType = 1,
                //ImageGalery = new List<string>(),
                ParkingCount = 1,
                Price = 140000,
                PropertyType = 1,
                RegimeType = 1,
                RoomCount = 4,
                Title = "Casa luminosa en la calle princial"

            };

            property.SetProfileImage(new Bitmap(Resources.casa_1));

            propertyList.Add(property);

            _sqliteManager.InsertData(propertyList);
        }

        private void GenerateTestClients()
        {
            List<Client> clientList = new List<Client>();

            Client client = new Client()
            {
                Id = 1,
                EmailAddress = "cesarlozanolahoz@gmail.com",
                Name = "César",
                Surname = "Lozano Lahoz",
                PhoneNumber = "618 120 458",
                
            };

            client.SetProfileImage(new Bitmap(Resources.cara_1));

            clientList.Add(client);

            _sqliteManager.InsertData(clientList);
        }

        private void GenerateTestSearchProfiles()
        {

            SearchProfile clientSearchProfile = new SearchProfile()
            {
                Id = 1,
                ClientId = 1,
                Name = "Búsqueda casa",
                AgeMax = new DateTime(1960, 1, 1),
                BathroomMin = 1,
                ParkingMin = 1,
                Pool = true,
                PriceMax = 160000,
                RegimeType = 1,
                RoomMin = 3,
                SizeMin = 100,

            };

            _sqliteManager.InsertData(clientSearchProfile);
        }

        private void GeneratePropertyOwners()
        {
            List<Dictionary<string, object>> propertyOwners = new List<Dictionary<string, object>>
            {
                new Dictionary<string, object>
                {
                    { "PropertyId", 1 },
                    { "ClientId", 1 },
                    { "PercentageOwnership", 100.0 }
                },
            };

            _sqliteManager.UpsertData(propertyOwners, "PropertyOwners", new List<string> { "PropertyId", "ClientId" });
        }

        private void RefreshContent()
        {
            this.propertySelectorUserControl.Init(_sqliteManager);
            this.clientSelectorUserControl.Init(_sqliteManager);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        #region Property controls handlers

        private void buttonPropertyNew_Click(object sender, EventArgs e)
        {
            PropertyDetailForm buildingDetailForm = new PropertyDetailForm(_sqliteManager, new Property());
            buildingDetailForm.Closed += (s, args) =>
            {
                RefreshContent();
                this.Show();
            };

            this.Hide();
            buildingDetailForm.Show();
        }

        private void buttonPropertyDetail_Click(object sender, EventArgs e)
        {
            Property selectedProperty = propertySelectorUserControl.GetSelectedItem();
            if (selectedProperty == null)
                return;

            PropertyDetailForm buildingDetailForm = new PropertyDetailForm(_sqliteManager, selectedProperty);
            buildingDetailForm.Closed += (s, args) =>
            {
                RefreshContent();
                this.Show();
            };

            this.Hide();
            buildingDetailForm.Show();
        }

        private void buttonPropertyDelete_Click(object sender, EventArgs e)
        {
            Property selectedProperty = propertySelectorUserControl.GetSelectedItem();
            if (selectedProperty == null)
                return;

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta propiedad?",
                                     "Confirmar borrado",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _sqliteManager.DeleteData<Property>(selectedProperty.Id);
                RefreshContent();
            }
        }

        #endregion

        #region Client controls handlers

        private void buttonClientNew_Click(object sender, EventArgs e)
        {
            ClientDetailForm clientDetailForm = new ClientDetailForm(_sqliteManager, new Client());
            clientDetailForm.Closed += (s, args) =>
            {
                RefreshContent();
                this.Show();
            };

            this.Hide();
            clientDetailForm.Show();
        }

        private void buttonClientDetail_Click(object sender, EventArgs e)
        {
            Client selectedClient = clientSelectorUserControl.GetSelectedItem();
            if (selectedClient == null)
                return;

            ClientDetailForm clientDetailForm = new ClientDetailForm(_sqliteManager, selectedClient);
            clientDetailForm.Closed += (s, args) =>
            {
                RefreshContent();
                this.Show();
            };

            this.Hide();
            clientDetailForm.Show();
        }

        private void buttonClientDelete_Click(object sender, EventArgs e)
        {
            Client selectedClient = clientSelectorUserControl.GetSelectedItem();
            if (selectedClient == null)
                return;

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?",
                                     "Confirmar borrado",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _sqliteManager.DeleteData<Client>(selectedClient.Id);
                RefreshContent();
            }
        }

        #endregion

    }
}
