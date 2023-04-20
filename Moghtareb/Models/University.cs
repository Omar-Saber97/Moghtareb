using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moghtareb.Models
{
    [Table("University")]
    public class University:BaseEntity
    {

        [MaxLength(50)]
        public string Name { get; set; }

        public string? Location { get; set; }

        public virtual ICollection<Fuclty>? Fuclties { get; set; }
    }
}
