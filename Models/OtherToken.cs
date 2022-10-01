using System.ComponentModel.DataAnnotations.Schema;

namespace MyNFTTracker.Models
{
    public class OtherToken
    {
        public int Id { get; set; }
        public string Caption { get; set; } = null!;
        public string? Link { get; set; }
        [Column(TypeName = "decimal(9, 8)")] public decimal Profit { get; set; }
        public bool Simulation { get; set; } = false;
        public string? Comment { get; set; }
        public DateTime CreationDate { get; set; }
        public Project Project { get; set; } = null!;
        public AppUser User { get; set; } = null!;
    }
}
