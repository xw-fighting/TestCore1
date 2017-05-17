using System;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    /// <summary>
    /// 前台注册使用
    /// </summary>
    public class User
    {
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(50)]
        [Required]

        public string LoginName { get; set; }
        [MaxLength(40)]
        [Required]

        public string LoginPwd { get; set; }
        [MaxLength(40)]
        [Required]

        public string Email { get; set; }
        [MaxLength(40)]
        [Required]

        public string Phone { get; set; }

        public DateTime RegisterTime { get; set; }

        public virtual  UserInfo UserInfo { get; set; }

    }
}
