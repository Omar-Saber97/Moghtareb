using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moghtareb.Models
{
    public enum MaritialStatus
    {
        Single = 0,
        Married = 1,
        Engaged = 2,
        Devorce = 4
    }
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }

        public string? Address { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string JobTitle { get; set; }

        public bool IsTenant { get; set; }

        public bool IsSmoking { get; set; }
        public MaritialStatus MaritialStatus { get; set; }

        public int? FucltyId { get; set; }

        [ForeignKey("FucltyId")]
        public virtual Fuclty? Fuclty { get; set; }

        public virtual ICollection<Post>? Posts { get; set; }

        public virtual ICollection<UserUnits>? UserUnits { get; set; }

        [InverseProperty("Owner")]
        public virtual ICollection<Leese> OwnerLeeses { get; set; }
        [InverseProperty("Tentant")]
        public virtual ICollection<Leese> TentantLeeses { get; set; }

        public virtual Service Services { get; set; }

        public virtual ICollection<UsersLundries>? UsersLundries { get; set; }
        public virtual ICollection<UsersMaintenance>? UsersMaintenances { get; set; }
    }
}
