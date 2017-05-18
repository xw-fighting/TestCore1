using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
   
    public class UserManageInfo
    {

        public UserManageInfo()
        {
            this.UserManageInfoRole = new HashSet<UserManageInfoRole>();
            this.WorkFlowRequestForm = new HashSet<WorkFlowRequestForm>();
        }
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(40)]
        [Required]
        public string TelPhone { get; set; }
        [MaxLength(40)]
        [Required]
        public string Mobile { get; set; }
        [MaxLength(40)]
        [Required]
        public string Email { get; set; }
        [MaxLength(40)]
        [Required]
        public string QQ { get; set; }
        [MaxLength(4)]
        [Required]
        public int Gender { get; set; }
        [MaxLength(2)]
        [Required]
        public int Status { get; set; }
        [MaxLength(40)]
        [Required]
        public string CompanyId { get; set; }
        [MaxLength(40)]
        [Required]
        public string DepartmentId { get; set; }
        [MaxLength(40)]
        [Required]
        public string WorkGroupId { get; set; }
        [MaxLength(250)]
        [Required]
        public string Remark { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        [MaxLength(40)]
        [Required]
        public string UpdateId { get; set; }
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 与组织机构关联
        /// </summary>
        public virtual OrganStruct OrganStruct1 { get; set; }
        public virtual OrganStruct OrganStruct2 { get; set; }
        public virtual OrganStruct OrganStruct3 { get; set; }

        public virtual ICollection<UserManageInfoRole> UserManageInfoRole { get; set; }

        public virtual ICollection<WorkFlowRequestForm> WorkFlowRequestForm { get; set; }


    }
}
