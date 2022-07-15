using System;


namespace HerbalApothecary.Models
{
    public class InventoryItem
    {
        public int InventoryItemId { get; set; }
        public int HerbId { get; set; }
        public double Quantity { get; set; }
    }
}

