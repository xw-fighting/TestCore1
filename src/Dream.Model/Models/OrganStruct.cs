using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dream.Model.Models
{
    /// <summary>
    /// 组织机构
    /// </summary>
    public class OrganStruct
    {
        public OrganStruct()
        {
            this.Role = new HashSet<Role>();
            this.UserManageInfo = new HashSet<UserManageInfo>();
        }
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string ParentId { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Code { get; set; }
        /// <summary>
        /// 所属类别：如集团，公司，部门
        /// </summary>
        /// 
        [MaxLength(40)]
        [Required]
        public string CateId { get; set; }
        [MaxLength(10)]
        [Required]
        public Nullable<int> Level { get; set; }
        [MaxLength(50)]
        [Required]
        public string ShortName { get; set; }
        [MaxLength(240)]
        [Required]
        public string Remark { get; set; }
        [MaxLength(2)]
        [Required]
        public Nullable<int> Status { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        [MaxLength(40)]
        [Required]
        public string UpdateId { get; set; }
        public DateTime UpdateTime { get; set; }
        public virtual KeyValue KeyValue { get; set; }
        public virtual ICollection<Role> Role { get; set; }
        public virtual ICollection<UserManageInfo> UserManageInfo { get; set; }

        public virtual ICollection<UserManageInfo> UserManageInfo1 { get; set; }

    }
}
