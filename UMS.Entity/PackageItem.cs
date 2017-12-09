using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Entity
{
    public class PackageItem
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int? promoId { get; set; }

        [ForeignKey("promoId")]
        public Promotion Promotion { get; set; }
        public int itemType { get; set; }
        [ForeignKey("itemType")]
        public ItemType ItemType { get; set; }
        public ICollection<PackageDetails> PackageDetails { get; set; }
        public PackageItem()
        {

        }
    }
}
