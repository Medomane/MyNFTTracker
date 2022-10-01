using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    [Table("User")]
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool ShowData { get; set; } = false;
        public string? Twitter { get; set; }            
        public string? Discord { get; set; }
        public string Role { get; set; } = null!;
        public bool HasNft { get; set; } = true;
        public DateTime CreationDate { get; set; }
        public List<Wallet>? Wallets { get; set; }
        public List<OtherToken>? OtherTokens { get; set; }
        public List<NonFungibleTokenLine>? NonFungibleTokenLines { get; set; }
        public List<BalanceLog>? BalanceLogs { get; set; }
    }
}