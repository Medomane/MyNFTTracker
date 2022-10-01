using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class BalanceHistory : Balance
    {
        public Wallet Wallet { get; set; } = null!;
    }
}
