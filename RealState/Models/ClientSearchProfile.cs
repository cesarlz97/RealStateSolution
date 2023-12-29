using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class ClientSearchProfile
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int PropertyType { get; set; }
        public int RegimeType { get; set; }
        public DateTime AgeMax { get; set; }
        public int SizeMin { get; set; }
        public int PriceMax { get; set; }
        public int RoomMin { get; set; }
        public int BathroomMin { get; set; }
        public int ParkingMin { get; set; }
        public bool Pool { get; set; }

        public ClientSearchProfile() { }
    }
}
