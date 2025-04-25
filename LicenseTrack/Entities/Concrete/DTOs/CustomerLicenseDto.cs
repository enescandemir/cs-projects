using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CustomerLicenseDto
    {
        public int LicenseID { get; set; }
        public string CustomerName { get; set; }
        public int Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }

}
