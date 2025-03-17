using Core.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class UpdateTable : IEntity
    {
        [Key]
        public int UpdateID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int VersionID { get; set; }

        [Required]
        public DateTime UpdateDate { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
    }

}
