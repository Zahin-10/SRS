using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Entity
{
    public class Invoice
    {
        public int Id { get; set; }
        public string uid { get; set; }
        [ForeignKey("uid")]
        public Authentication Authentication { get; set; }

        public double totalPrice { get; set; }
        public int status { get; set; }
        public int? promoId { get; set; }

        [ForeignKey("promoId")]
        public Promotion Promotion { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public Invoice()
        {

        }
    }
}
