using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moghtareb.Models
{
    [Table("Fuclty")]
    public class Fuclty : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        public int UniversityId { get; set; }

        [ForeignKey("UniversityId")]
        public virtual University? University { get; set; }

        public virtual ICollection<ApplicationUser>? Students { get; set; }
    }
}
