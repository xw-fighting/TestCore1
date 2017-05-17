using System;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    /// <summary>
    /// 用户注册后补充详细信息
    /// </summary>
    public class UserInfo
    {
        [Key]
        [MaxLength(40)]
        [Required]
        public string  Id { get; set; }

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
        [MaxLength(2)]
        [Required]
        public int Gender { get; set; }
        [MaxLength(2)]
        [Required]
        public int Status { get; set; }
        [MaxLength(150)]
        [Required]
        public string CompanyName { get; set; }
        [MaxLength(140)]
        [Required]
        public Nullable<int> DepartmentName { get; set; }
        [MaxLength(240)]
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

        
    }
}
