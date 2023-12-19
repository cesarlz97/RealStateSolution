using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int ContractType { get; set; }
        public int Amount { get; set; }
        public DateTime SignatureDate { get; set; }


        Dictionary<Client, int> SellersSoldPercentage { get; set; }
        Dictionary<Client, int> BuyersBoughtPercentage { get; set; }

    }
}
