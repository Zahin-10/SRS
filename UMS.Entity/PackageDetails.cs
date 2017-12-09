using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Entity
{
    public class PackageDetails
    {
        public int Id { get; set; }
        public int packageid { get; set; }

        [ForeignKey("packageid")]
        public PackageItem PackageItem { get; set; }

        public PackageDetails()
        {

        }
    }
}
