using log4net;
using log4net.Util;
using RealState.CustomControls;
using RealState.Models;
using RealState.Models.TwitterAPI;
using RealState.Properties;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace RealState.Forms
{
    public partial class MainForm : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private SQLiteManager _sqliteManager;

        private User _user;

        private List<Property> _propertiesPublishedOnTwitter;

        public MainForm(SQLiteManager sqliteManager, User user)
        {
            InitializeComponent();

            _sqliteManager = sqliteManager;
            _user = user;

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

            property.SetProfileImage(new Bitmap(Resources.Property_Dafault_Profile_Image));

            propertyList.Add(property);

            _sqliteManager.InsertData(propertyList);
        }

        private void GenerateTestClients()
        {
            List<Client> clientList = new List<Client>();

            Client client = new Client()
            {
                Id = 1,
                EmailAddress = "cesar.lozano@gmail.com",
                Name = "César",
                Surname = "Lozano Lahoz",
                PhoneNumber = "000 000 000",
                
            };

            client.SetProfileImage(new Bitmap(Resources.Client_Default_Profile_Image));

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
            PopulateSocialNetworkProfileFields();
            LoadPublishedProperties();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        void listBoxPropertiesPublishedOnTwitter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxPropertiesPublishedOnTwitter.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;

            PropertyDetailForm PropertyDetailForm = new PropertyDetailForm(_sqliteManager, _propertiesPublishedOnTwitter[index]);
            PropertyDetailForm.Closed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            PropertyDetailForm.Show();
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

        private TwitterProfile _twitterProfile = null;
        private Property _selectedPropertyToPublishOnTwitter = null;

        private void PopulateSocialNetworkProfileFields()
        {
            Dictionary<string, object> whereClauses = new Dictionary<string, object>() { { nameof(TwitterProfile.Id), _user.Id } };
            _twitterProfile = _sqliteManager.ReadData<TwitterProfile>(whereClauses: whereClauses).FirstOrDefault();

            if (_twitterProfile != null)
            {
                textBoxTwitterApiKey.Text = _twitterProfile.ApiKey;
                textBoxTwitterApiKeySecret.Text = _twitterProfile.ApiKeySecret;
                textBoxTwitterAccessToken.Text = _twitterProfile.AccessToken;
                textBoxTwitterAccessTokenSecret.Text = _twitterProfile.AccessTokenSecret;
            }
        }

        private void buttonSaveTwitterCredentials_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas sobrescribir los datos?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool exists = _twitterProfile != null;
                
                _twitterProfile = new TwitterProfile()
                {
                    Id = _user.Id,
                    ApiKey = textBoxTwitterApiKey.Text.Trim(),
                    ApiKeySecret = textBoxTwitterApiKeySecret.Text.Trim(),
                    AccessToken = textBoxTwitterAccessToken.Text.Trim(),
                    AccessTokenSecret = textBoxTwitterAccessTokenSecret.Text.Trim(),
                };

                if (exists)
                    _sqliteManager.UpdateData(_twitterProfile, whereClauses: new Dictionary<string, object>() { { nameof(TwitterProfile.Id), _twitterProfile.Id } });
                else
                    _twitterProfile.Id = (int)_sqliteManager.InsertData(_twitterProfile);

                MessageBox.Show("¡Credenciales actualizadas en la base de datos!",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void buttonSelectPropertyToPublish_Click(object sender, EventArgs e)
        {
            ItemSelectorForm<Property> propertySelector = new ItemSelectorForm<Property>(_sqliteManager);
            propertySelector.Closed += (s, args) =>
            {
                if (propertySelector.SelectedItem != null)
                {
                    labelSelectedPropertyTitle.Text = propertySelector.SelectedItem.Title;
                    _selectedPropertyToPublishOnTwitter = propertySelector.SelectedItem;
                }
                this.Show();
            };

            this.Hide();
            propertySelector.Show();
        }

        private void buttonPublishPropertyOnTwitter_Click(object sender, EventArgs e)
        {
            if (_selectedPropertyToPublishOnTwitter != null && _twitterProfile != null) PublishPropertyOnTwitter();
        }

        private void PublishPropertyOnTwitter()
        {
            try
            {
                string mediaId = UploadPropertyProfileImageToTwitter();

                string url = "https://api.twitter.com/2/tweets";
                var request = GenerateTwitterRequest(HttpMethod.Post, url);

                TwitterPublishTweetRequest tweet = new TwitterPublishTweetRequest(_selectedPropertyToPublishOnTwitter.Title, new List<string>() { mediaId });

                var content = new StringContent(JsonSerializer.Serialize(tweet), null, "application/json");
                request.Content = content;

                var client = new HttpClient();
                var response = client.SendAsync(request).Result;
                response.EnsureSuccessStatusCode();
                string responseContent = response.Content.ReadAsStringAsync().Result;

                RegisterPublishedPropertyInDatabase();

                LoadPublishedProperties();
            }
            catch (Exception ex)
            {
                Log.ErrorExt(ex);
            }
        }

        private void LoadPublishedProperties()
        {
            _propertiesPublishedOnTwitter = _sqliteManager.ReadData<Property>(
                joinClauses: new Dictionary<string, string>
                {
                    { "PublishedProperties", $"{_sqliteManager.GetTableName<Property>()}.{nameof(Property.Id)} = PropertyId" }
                },
                whereClauses: new Dictionary<string, object> { { "TwitterProfileId", _twitterProfile?.Id } }
            );

            listBoxPropertiesPublishedOnTwitter.Items.Clear();
            foreach (var property in _propertiesPublishedOnTwitter)
                listBoxPropertiesPublishedOnTwitter.Items.Add(property.Title);
        }

        private void RegisterPublishedPropertyInDatabase()
        {
            Dictionary<string,object> entity = new Dictionary<string, object>()
            {
                { "TwitterProfileId", _twitterProfile.Id },
                { "PropertyId", _selectedPropertyToPublishOnTwitter.Id },
            };
            _sqliteManager.UpsertData(new List<Dictionary<string, object>>() { entity }, "PublishedProperties", new List<string>() { "TwitterProfileId", "PropertyId" });
        }

        private string UploadPropertyProfileImageToTwitter()
        {
            string url = "https://upload.twitter.com/1.1/media/upload.json";
            var request = GenerateTwitterRequest(HttpMethod.Post, url);

            Image image = _selectedPropertyToPublishOnTwitter.GetProfileImage();
            ImageConverter converter = new ImageConverter();
            byte[] imageBytes = (byte[])converter.ConvertTo(image, typeof(byte[]));

            // Crear el contenido multipart
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new ByteArrayContent(imageBytes), "media", $"property_{_selectedPropertyToPublishOnTwitter.Id}_profile_image.jpeg");
                request.Content = content;

                var client = new HttpClient();
                var response = client.SendAsync(request).Result;
                //response.EnsureSuccessStatusCode();
                string responseContent = response.Content.ReadAsStringAsync().Result;
                TwitterUploadMediaResponse uploadMediaResponse = JsonSerializer.Deserialize<TwitterUploadMediaResponse>(responseContent);

                return uploadMediaResponse.media_id_string;
            }
        }

        private HttpRequestMessage GenerateTwitterRequest(HttpMethod method, string url)
        {
            var request = new HttpRequestMessage(method, url);

            string oauth_consumer_key = _twitterProfile.ApiKey;
            string oauth_token = _twitterProfile.AccessToken;
            string oauth_signature_method = "HMAC-SHA1";
            string oauth_timestamp = GenerateOauthTimestamp();
            string oauth_nonce = GenerateOAuthNonce();
            string oauth_version = "1.0";

            Dictionary<string, string> parameters = new Dictionary<string, string>()
            {
                { "oauth_consumer_key", oauth_consumer_key},
                { "oauth_nonce", oauth_nonce},
                { "oauth_signature_method", oauth_signature_method},
                { "oauth_timestamp", oauth_timestamp},
                { "oauth_token", oauth_token},
                { "oauth_version", oauth_version},
            };

            string oauth_signature = GetSignature(method, url, parameters);

            // Construir el encabezado de autorización
            string authorizationHeader = $"OAuth oauth_consumer_key=\"{Uri.EscapeDataString(oauth_consumer_key)}\", " +
                                        $"oauth_nonce=\"{Uri.EscapeDataString(oauth_nonce)}\", " +
                                        $"oauth_signature=\"{Uri.EscapeDataString(oauth_signature)}\", " +
                                        $"oauth_signature_method=\"{Uri.EscapeDataString(oauth_signature_method)}\", " +
                                        $"oauth_timestamp=\"{Uri.EscapeDataString(oauth_timestamp)}\", " +
                                        $"oauth_token=\"{Uri.EscapeDataString(oauth_token)}\", " +
                                        $"oauth_version=\"{Uri.EscapeDataString(oauth_version)}\"";

            request.Headers.Add("Authorization", authorizationHeader);

            return request;
        }

        static string GenerateOAuthNonce()
        {
            // Generate 32 bytes of random data
            byte[] randomBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomBytes);
            }

            // Convert the random data to base64 and remove non-word characters
            string base64String = Convert.ToBase64String(randomBytes);
            string alphanumericString = RemoveNonWordCharacters(base64String);

            return alphanumericString;
        }

        static string RemoveNonWordCharacters(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        private string GetSignature(HttpMethod httpMethod, string baseUrl, Dictionary<string, string> parameters)
        {
            // Generate parameter string
            string parameterString = GenerateParameterString(parameters);

            // Create the signature base string
            string signatureBaseString = GenerateSignatureBaseString(httpMethod.ToString(), baseUrl, parameterString);

            // Get the signing key
            string consumerSecret = _twitterProfile.ApiKeySecret;
            string tokenSecret = _twitterProfile.AccessTokenSecret;
            string signingKey = $"{UrlEncode(consumerSecret)}&{UrlEncode(tokenSecret)}";

            // Calculate the signature
            string oauthSignature = GenerateHmacSha1Signature(signatureBaseString, signingKey);

            return oauthSignature;
        }

        static string GenerateParameterString(Dictionary<string, string> parameters)
        {
            var encodedParams = new List<string>();
            foreach (var pair in parameters)
            {
                encodedParams.Add($"{UrlEncode(pair.Key)}={UrlEncode(pair.Value)}");
            }
            return string.Join("&", encodedParams);
        }

        static string GenerateSignatureBaseString(string httpMethod, string baseUrl, string parameterString)
        {
            return $"{httpMethod.ToUpper()}&{UrlEncode(baseUrl)}&{UrlEncode(parameterString)}";
        }

        static string GenerateHmacSha1Signature(string data, string key)
        {
            using (var hmacsha1 = new HMACSHA1(Encoding.UTF8.GetBytes(key)))
            {
                byte[] hashBytes = hmacsha1.ComputeHash(Encoding.UTF8.GetBytes(data));
                return Convert.ToBase64String(hashBytes);
            }
        }

        static string UrlEncode(string value)
        {
            return Uri.EscapeDataString(value);
        }

        private string GenerateOauthTimestamp()
        {
            DateTime currentTime = DateTime.UtcNow;

            // Calcular la diferencia en segundos desde la época de Unix (1 de enero de 1970)
            TimeSpan timeSinceEpoch = currentTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return ((long)timeSinceEpoch.TotalSeconds).ToString();
        }

    }
}
