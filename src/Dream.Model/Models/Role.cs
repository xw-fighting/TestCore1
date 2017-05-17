using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    public class Role
    {
        public Role()
        {
            this.PermissList = new HashSet<PermissList>();
            this.UserManageInfoRole = new HashSet<UserManageInfoRole>();
        }
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [MaxLength(40)]
        [Required]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 从字典表中获取（与字典表中的Id关联）---（多对一）
        /// </summary>
        /// 
        [MaxLength(40)]
        [Required]
        public string RoleType { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(240)]
        [Required]
        public string Remark { get; set; }
        [MaxLength(3)]
        [Required]
        public int Sort { get; set; }
        [MaxLength(2)]
        [Required]
        public int Status { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        [MaxLength(40)]
        [Required]
        public string UpdateId { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual ICollection<PermissList> PermissList { get; set; }

        public virtual OrganStruct OrganStruct { get; set; }

        public virtual KeyValue KeyValue { get; set; }

        public virtual ICollection<UserManageInfoRole> UserManageInfoRole { get; set; }

    }
}
