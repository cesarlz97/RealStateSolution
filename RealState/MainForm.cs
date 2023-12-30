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

        private List<Property> PropertyList { get; set; }
        private List<Client> ClientList { get; set; }
        
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
            PropertyList = new List<Property>();

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

            PropertyList.Add(property);

            _sqliteManager.InsertData(PropertyList);
        }

        private void GenerateTestClients()
        {
            ClientList = new List<Client>();

            Client client = new Client()
            {
                Id = 1,
                EmailAddress = "cesarlozanolahoz@gmail.com",
                Name = "César",
                Surname = "Lozano Lahoz",
                PhoneNumber = "618 120 458",
                
            };

            client.SetProfileImage(new Bitmap(Resources.cara_1));

            ClientList.Add(client);

            _sqliteManager.InsertData(ClientList);
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

        private void PopulatePropiertiesTab(int? limit = null, int? offset = null)
        {
            exListBoxUserControlBuilding.Items.Clear();

            PropertyList = _sqliteManager.ReadData<Property>(limit: limit, offset: offset);
            foreach (Property property in PropertyList)
            {
                string details = string.Format(
                    "Antiguedad: {0} años \n" +
                    "Superficie: {1} m2 \n" +
                    "Precio: {2} €",
                    property.GetAge(),
                    property.AreaUtil,
                    property.Price);

                ExListBoxItem exListBoxItem = new ExListBoxItem(property.Id, property.Title, details, property.GetProfileImage());

                this.exListBoxUserControlBuilding.Items.Add(exListBoxItem);
            }
        }

        private void PopulateClientsTab(int? limit = null, int? offset = null)
        {
            exListBoxUserControlClient.Items.Clear();

            ClientList = _sqliteManager.ReadData<Client>(limit: limit, offset: offset);
            foreach (Client client in ClientList)
            {
                string fullName = string.Format("{0} {1}", client.Name, client.Surname);
                string details = string.Format(
                    "Email: {0} \n" +
                    "Teléfono: {1} \n",
                    client.EmailAddress,
                    client.PhoneNumber);

                ExListBoxItem exListBoxItem = new ExListBoxItem(client.Id, fullName, details, client.GetProfileImage());

                this.exListBoxUserControlClient.Items.Add(exListBoxItem);
            }
        }

        private void RefreshContent()
        {
            PopulatePropiertiesTab(limit: 10);
            PopulateClientsTab(limit: 10);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void ExListBoxUserControlBuilding_ItemSelectionChanged(object sender, EventArgs e)
        {
            BuildingDetailForm buildingDetailForm = new BuildingDetailForm(_sqliteManager, PropertyList[exListBoxUserControlBuilding.SelectedIndex]);
            buildingDetailForm.Closed += (s, args) =>
            {
                RefreshContent();
                this.Show();
            };

            this.Hide();
            buildingDetailForm.Show();
        }

        private void ExListBoxUserControlClient_ItemSelectionChanged(object sender, EventArgs e)
        {
            ClientDetailForm clientDetailForm = new ClientDetailForm(_sqliteManager, ClientList[exListBoxUserControlClient.SelectedIndex]);
            clientDetailForm.Closed += (s, args) =>
            {
                RefreshContent();
                this.Show();
            };

            this.Hide();
            clientDetailForm.Show();
        }

        private void buttonNewBuidling_Click(object sender, EventArgs e)
        {
            BuildingDetailForm buildingDetailForm = new BuildingDetailForm(_sqliteManager, new Property());
            buildingDetailForm.Closed += (s, args) =>
            {
                RefreshContent();
                this.Show();
            };

            this.Hide();
            buildingDetailForm.Show();
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
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
    }
}
