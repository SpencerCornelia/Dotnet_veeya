using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Veeya.Controllers.Resources
{
    public class WholesalerResource
    {
        public int id { get; set; }
        public string First_Name { get; set; }
        
        public ICollection<PropertyResource> Properties { get; set; }

        public WholesalerResource() 
        {
            Properties = new Collection<PropertyResource>();
        }
    }
}