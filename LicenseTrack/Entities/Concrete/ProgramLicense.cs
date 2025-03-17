using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class ProgramLicense : IEntity
    {
        [Key]
        public int ProgramLicenseID { get; set; }

        [Required]
        public int ProgramID { get; set; }

        [Required]
        public int LicenseID { get; set; }
    }

}
