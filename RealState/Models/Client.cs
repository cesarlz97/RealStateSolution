using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ProfileImage { get; set; }
        //public List<ClientSearchProfile> SearchProfiles { get; set; }
        public Client()
        {
            //SearchProfiles = new List<ClientSearchProfile>();
        }

        public Image GetProfileImage()
        {
            if (string.IsNullOrWhiteSpace(ProfileImage))
                return null;

            byte[] imageBytes = Convert.FromBase64String(ProfileImage);

            Image image;
            // Create a MemoryStream from the byte array
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Create an Image object from the MemoryStream
                image = Image.FromStream(ms);
            }

            return image;
        }

        public void SetProfileImage(Image image)
        {
            if (image == null)
            {
                ProfileImage = string.Empty;
                return;
            }

            // Convert the Image to a MemoryStream
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the Image to the MemoryStream in a specific format (e.g., PNG)
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                // Convert the MemoryStream to a byte array
                byte[] imageBytes = ms.ToArray();

                // Convert the byte array to a Base64 string
                ProfileImage = Convert.ToBase64String(imageBytes);
            }
        }
    }
}
