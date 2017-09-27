using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    [Table("Properties")]
    public class Property
    {
        public int PropertyId { get; set; }

        [Required]
        [StringLength(255)]
        public string AddressName { get; set; }

        public Wholesaler Wholesaler { get; set; }

        public int WholesalerId { get; set;}
        
    }
}