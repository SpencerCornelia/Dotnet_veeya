using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Veeya.Models
{
    public class Wholesaler
    {
        public int id { get; set; }
        public string First_Name { get; set; }
        public ICollection<Property> Properties { get; set; }

        public Wholesaler() 
        {
            Properties = new Collection<Property>();
        }
    }
}