using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class NonFungibleToken
    {
        public int Id { get; set; }
        public string MintAddress { get; set; } = null!;
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(9, 8)")] public decimal SellerFeeBasisPoints { get; set; }
        public string Image { get; set; } = null!;
        public string? Rarity { get; set; }
        public int? RarityRank { get; set; }
        public Project Project { get; set; } = null!;
        public List<NonFungibleTokenLine>? NonFungibleTokenLines { get; set; }
    }
}
