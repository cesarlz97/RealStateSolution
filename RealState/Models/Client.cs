using RealState.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class Client : IListable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ProfileImage { get; set; }
        
        public Client() { }

        public Image GetProfileImage()
        {
            if (string.IsNullOrWhiteSpace(ProfileImage))
                return null;

            byte[] imageBytes = Convert.FromBase64String(ProfileImage);

            Image image;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
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

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                ProfileImage = Convert.ToBase64String(imageBytes);
            }
        }

        public int GetId()
        {
            return Id;
        }

        public string GetTitle()
        {
            return $"{Name} {Surname}";
        }

        public string GetGetails()
        {
            return string.Format(
                    "Email: {0} \n" +
                    "Teléfono: {1} \n",
                    EmailAddress,
                    PhoneNumber);
        }

        public string GetSearchFieldName()
        {
            return nameof(Surname);
        }
    }
}
