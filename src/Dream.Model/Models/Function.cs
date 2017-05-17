using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dream.Model.Models
{
    /// <summary>
    /// 菜单的方法名的集合
    /// </summary>
    public class Function
    {
        public Function()
        {
            this.PermissList = new HashSet<PermissList>();
        }
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string MenuId { get; set; }
        /// <summary>
        /// 菜单方法按钮名
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 菜单的action方法名,来自KeyValue
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string ActionName { get; set; }
        /// <summary>
        /// 图标名称
        /// </summary>
        /// 
        [MaxLength(50)]
        [Required]
        public string PicName { get; set; }
        [MaxLength(2)]
        [Required]

        public Nullable<int> Status { get; set; }
        /// <summary>
        /// 创建者编号
        /// </summary>
        /// 
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }

        [MaxLength(40)]
        [Required]
        public string UpdateId { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual Menu Menus { get; set; }

        public virtual ICollection<PermissList> PermissList { get; set; }
    }
}
