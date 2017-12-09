using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Entity
{
    public class Orders
    {
        public int Id { get; set; }
        public int invoiceid { get; set; }
        [ForeignKey("invoiceid")]
        public Invoice Invoice { get; set; }
        public int itemid { get; set; }
        [ForeignKey("itemid")]
        public Item Item { get; set; }
        public int itemQuantity { get; set; }

        public double totalPrice { get; set; }
        public int itemType { get; set; }
        [ForeignKey("itemType")]
        public ItemType ItemType { get; set; }
        
        public Orders()
        {

        }
    }
}
