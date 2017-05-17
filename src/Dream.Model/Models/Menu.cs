using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    public class Menu
    {
        public Menu()
        {
            this.Function = new HashSet<Function>();
            this.PermissList = new HashSet<PermissList>();
        }
        /// <summary>
        /// 1、作为Function的外键---（一对多） 与Function中的MenuId字段关联
        /// 2、作为PermissList的外键---（一对多）与PermissList中的MenuId字段关联
        /// </summary>
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string ParentId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(400)]
        [Required]
        public string Url { get; set; }
        [MaxLength(50)]
        [Required]
        public string Area { get; set; }
        [MaxLength(50)]
        [Required]
        public string Controller { get; set; }
        [MaxLength(50)]
        [Required]
        public string Action { get; set; }
        [MaxLength(5)]
        [Required]
        public string SortId { get; set; }
        [MaxLength(2)]
        [Required]
        public int Status { get; set; }
        [MaxLength(50)]
        [Required]
        public string PicName { get; set; }
        [MaxLength(3)]
        [Required]
        public int Level { get; set; }
        /// <summary>
        /// 备用字段
        /// </summary>
        /// 
        [MaxLength(250)]
        [Required]
        public string Expl { get; set; }
        /// <summary>
        /// 备用字段 0：表示左菜单显示  1：
        /// </summary>
        /// 
        [MaxLength(5)]
        [Required]
        public Nullable<int> Exp2 { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        [MaxLength(40)]
        [Required]
        public string UpdateId { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual ICollection<Function> Function { get; set; }
        
        public virtual ICollection<PermissList> PermissList { get; set; }
    }
}
