using System.Collections.Generic;
using System.Collections.ObjectModel;
using Veeya.Models;

namespace Veeya.Controllers.Resources
{
    public class InvestorResource
    {
        public int id { get; set; }
        
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email_Address { get; set; }
       
        public string Phone_Number { get; set; }

        public ICollection<WholesalerResource> Wholesalers { get; set; }

        public InvestorResource()
        {
            Wholesalers = new Collection<WholesalerResource>();
        }
    }
}