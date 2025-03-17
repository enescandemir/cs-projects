using Core.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class License : IEntity
    {
        [Key]
        public int LicenseID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int Type { get; set; } // 1 = Demo, 2 = 6 Aylık

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
    }

}
