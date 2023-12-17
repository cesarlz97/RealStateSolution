using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class SocialNetworkProfile
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool AutomaticPublish { get; set; }
        public Dictionary<int,string> PublishedProperties { get; set; }
        public SocialNetworkProfile() { }
    }
}
