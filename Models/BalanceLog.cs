using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class BalanceLog : Balance
    {
        public AppUser User { get; set; } = null!;
    }
}