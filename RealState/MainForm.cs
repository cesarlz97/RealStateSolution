using RealState.CustomControls;
using RealState.Models;
using RealState.Properties;
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
    public partial class MainForm : Form
    {
        private List<Property> PropertyList { get; set; }
        private List<Client> ClientList { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
            
            GenerateTestProperties();
            GenerateTestClients();
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
                ImageGalery = new List<string>(),
                ImageProfile = string.Empty,
                IsPublished = false,
                ParkingCount = 1,
                Price = 140000,
                PropertyType = 1,
                RegimeType = 1,
                RoomCount = 4,
                Title = "Casa luminosa en la calle princial"

            };

            PropertyList.Add(property);
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

            ClientSearchProfile clientSearchProfile = new ClientSearchProfile()
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

            client.SearchProfiles.Add(clientSearchProfile);

            ClientList.Add(client);
        }

        private void PopulatePropiertiesTab()
        {
            foreach (Property property in PropertyList)
            {
                string details = string.Format(
                    "Antiguedad: {0} años \n" +
                    "Superficie: {1} m2 \n" +
                    "Precio: {2} €",
                    property.GetAge(),
                    property.AreaUtil,
                    property.Price);

                Image image = new Bitmap(Resources.casa_1);

                ExListBoxItem exListBoxItem = new ExListBoxItem(property.Id, property.Title, details, image);

                this.exListBoxUserControlBuilding.Items.Add(exListBoxItem);
            }
        }

        private void PopulateClientsTab()
        {
            foreach (Client client in ClientList)
            {
                string fullName = string.Format("{0} {1}", client.Name, client.Surname);
                string details = string.Format(
                    "Email: {0} \n" +
                    "Teléfono: {1} m2 \n" +
                    "Perfil: {2}",
                    client.EmailAddress,
                    client.PhoneNumber,
                    "Comprador");

                Image image = new Bitmap(Resources.cara_1);

                ExListBoxItem exListBoxItem = new ExListBoxItem(client.Id, fullName, details, image);

                this.exListBoxUserControlClient.Items.Add(exListBoxItem);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulatePropiertiesTab();
            PopulateClientsTab();
        }

        private void ExListBoxUserControlBuilding_ItemSelectionChanged(object sender, EventArgs e)
        {
            BuildingDetailForm buildingDetailForm = new BuildingDetailForm(PropertyList[exListBoxUserControlBuilding.SelectedIndex]);
            buildingDetailForm.Closed += (s, args) => this.Show();

            this.Hide();
            buildingDetailForm.Show();
        }

        private void ExListBoxUserControlClient_ItemSelectionChanged(object sender, EventArgs e)
        {
            ClientDetailForm clientDetailForm = new ClientDetailForm(ClientList[exListBoxUserControlClient.SelectedIndex]);
            clientDetailForm.Closed += (s, args) => this.Show();

            this.Hide();
            clientDetailForm.Show();
        }

        private void buttonNewBuidling_Click(object sender, EventArgs e)
        {
            BuildingDetailForm buildingDetailForm = new BuildingDetailForm();
            buildingDetailForm.Closed += (s, args) => this.Show();

            this.Hide();
            buildingDetailForm.Show();
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            ClientDetailForm clientDetailForm = new ClientDetailForm();
            clientDetailForm.Closed += (s, args) => this.Show();

            this.Hide();
            clientDetailForm.Show();
        }
    }
}
