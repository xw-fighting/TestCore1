using System;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    public class PermissList
    {
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string RoleId { get; set; }

        [MaxLength(40)]
        [Required]
        public string MenuId { get; set; }
        [MaxLength(40)]
        [Required]
        public string FunctionId { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Function Function { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Role Role { get; set; }
    }
}
