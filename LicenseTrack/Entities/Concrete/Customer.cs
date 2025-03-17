using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int CustomerID { get; set; } 

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string DBName { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        public int? Port { get; set; }
    }

}
