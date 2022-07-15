using System;
namespace HerbalApothecary.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int HerbId { get; set; }
        public int InventoryItemId { get; set; }        
        public double Price { get; set; }
        public string? PriceMetric { get; set; }
        public string? Vendor { get; set; }
    }
}

