using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Caption { get; set; } = null!;
        public string Address { get; set; } = null!;
        [Column(TypeName = "decimal(9, 8)")] public decimal Balance { get; set; }
        public AppUser User { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public List<BalanceHistory>? BalanceHistories { get; set; }
    }
}
