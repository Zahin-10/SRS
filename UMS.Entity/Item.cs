using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public decimal? price { get; set; }
        public int? PromoId { get; set; }

        [ForeignKey("PromoId")]
        public Promotion Promotion { get; set; }

        public int itemType { get; set; }
        [ForeignKey("itemType")]
        public ItemType ItemType { get; set; }

        public Item()
        {

        }
    }
}
