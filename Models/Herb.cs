using System;
namespace HerbalApothecary.Models
{
    public class Herb
    {
        public int HerbId { get; set; }
        public string? CommonName { get; set; }
        public string? Uses { get; set; }
        public string? Contraindications { get; set; }
        public string? SideEffects { get; set; }
        public string? Tincture { get; set; }
        public string? Powder { get; set; }
        public string? Actions { get; set; }
        public string? Decoction { get; set; }
        public string? Energy { get; set; }
        public string? Notes { get; set; }
        public string? Safety { get; set; }        
        public string? KeyConstituents { get; set; }
        public string? ResearchFindings { get; set; }
        public string? BotanicalName { get; set; }
        public string? PartsUsed { get; set; }
        public string? Image { get; set; }
        public string? Referances { get; set; }
    }
}

