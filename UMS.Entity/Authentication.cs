using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Entity
{
    public class Authentication
    {
        [Key]
        public string Username { get; set; }
        public string pass { get; set; }
        //Foreign key for Standard
        public int userType { get; set; }

        [ForeignKey("userType")]
        public UserType UserType { get; set; }
        
        public Authentication()
        {
            
        }
    }
}
