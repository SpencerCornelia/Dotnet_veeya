using System.ComponentModel.DataAnnotations.Schema;

namespace Veeya.Models
{
    [Table("InvestorToWholesalers")]
    public class InvestorToWholesaler
    {
        public int InvestorId { get; set; }
        public Investor Investor { get; set; }
        public int WholesalerId { get; set; }
        public Wholesaler Wholesaler { get; set; }

    }
}