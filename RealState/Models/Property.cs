using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class Property
    {
        public int Id { get; set; }
        public List<int> OwnerClientsIds { get; }
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
        public List<string> ImageGalery { get; set; }
        public bool IsPublished { get; set; }

        public Property() { }

        public int GetAge()
        {
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            return (new DateTime(1, 1, 1) + (DateTime.Now - DeedTime)).Year - 1;
        }
    }
}
