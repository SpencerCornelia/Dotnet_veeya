using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    [Table("InvestorToWholesalers")]
    public class InvestorToWholesaler
    {
        [Key]
        public int InvestorId { get; set; }
        public int WholesalerId { get; set; }
        
        public virtual Investor Investor { get; set; }
        public virtual Wholesaler Wholesaler { get; set; }

    }
}