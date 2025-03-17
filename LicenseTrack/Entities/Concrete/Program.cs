using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Program : IEntity
    {
        [Key]
        public int ProgramID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }

}
