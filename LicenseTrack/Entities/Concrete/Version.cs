using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Version : IEntity
    {
        [Key]
        public int VersionID { get; set; }

        [Required]
        public int Type { get; set; } // 1 = Veritabanı, 2 = Program

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int? DependentID { get; set; }
    }

}
