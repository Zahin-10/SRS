using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace UMS.Entity
{
    public class Promotion
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double? discountRate { get; set; }
        public double? discountAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime start { get; set; }

        [Column(TypeName = "date")]
        public DateTime end { get; set; }
        public Promotion()
        {
           
        }
    }
}
