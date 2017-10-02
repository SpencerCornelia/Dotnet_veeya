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
        [Required]
        public int WholesalerId { get; set;}

        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public int PurchasePrice { get; set; }
        [Required]
        public int Bedrooms { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int RehabCostMin { get; set; }
        [Required]
        public int RehabCostMax { get; set; }
        [Required]
        public int AfterRepairValue { get; set; }
        public int AverageRent { get; set; }
        public int SquareFootage { get; set; }
        [Required]
        public string PropertyType { get; set; }
        public int YearBuilt { get; set; }
        // future feature public string Status { get; set; }
        // last two are comps and photos
    }
}