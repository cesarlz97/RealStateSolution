using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class Property
    {
        public int Id { get; set; }
        //public List<int> OwnerClientsIds { get; }
        public int PropertyType { get; set; }
        public int RegimeType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
        public DateTime DeedTime { get; set; }
        public int RoomCount { get; set; }
        public int BathroomCount { get; set; }
        public int ParkingCount { get; set; }
        public int AreaBuilt { get; set; }
        public int AreaUtil { get; set; }
        public int AreaPlot { get; set; }
        public int AreaKitchen { get; set; }
        public int HeatingSystemType { get; set; }
        public bool HasPool { get; set; }
        public bool HasAirConditioning { get; set; }
        public string ImageProfile { get; set; }
        //public List<string> ImageGalery { get; set; }

        public Property()
        {
            Id = 0;
            PropertyType = 0;
            RegimeType = 0;
            Title = string.Empty;
            Description = string.Empty;
            Price = 0;
            Address = string.Empty;
            DeedTime = DateTime.Parse("01/01/2000");
            RoomCount = 0;
            BathroomCount = 0;
            ParkingCount = 0;
            AreaBuilt = 0;
            AreaUtil = 0;
            AreaPlot = 0;
            AreaKitchen = 0;
            HeatingSystemType = 0;
            HasPool = false;
            HasAirConditioning = false;
            ImageProfile = string.Empty;
            // ImageGalery = new List<string>();
        }

        public int GetAge()
        {
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            return (new DateTime(1, 1, 1) + (DateTime.Now - DeedTime)).Year - 1;
        }

        public Image GetProfileImage()
        {
            if (ImageProfile == string.Empty)
                return null;

            byte[] imageBytes = Convert.FromBase64String(ImageProfile);

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
                ImageProfile = string.Empty;
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
                ImageProfile = Convert.ToBase64String(imageBytes);
            }
        }
    }
}
