using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    public class UserManageInfoRole
    {
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]

        public string UserId { get; set; }
        [MaxLength(40)]
        [Required]

        public string RoleId { get; set; }

        public virtual UserManageInfo UserManageInfo { get; set; }

        public virtual Role Role { get; set; }
    }
}
