using System;
using System.Collections.Generic;
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
        public List<ClientSearchProfile> SearchProfiles { get; set; }
        public Client()
        {
            SearchProfiles = new List<ClientSearchProfile>();
        }
    }
}
