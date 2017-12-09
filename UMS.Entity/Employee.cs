using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public int employeeType { get; set; }

        [ForeignKey("employeeType")]
        public EmployeeType EmployeeType { get; set; }

        public int? promoId { get; set; }

        [ForeignKey("promoId")]
        public Promotion Promotion { get; set; }

        public Employee()
        {

        }
    }
}
