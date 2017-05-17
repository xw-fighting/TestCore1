using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    /// <summary>
    /// 字典集合
    /// </summary>
    public class KeyValue
    {
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string ParentId { get; set; }

        [MaxLength(40)]
        [Required]
        public int Type { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Value { get; set; }
        [MaxLength(250)]
        [Required]
        public string Remark { get; set; }

        public virtual ICollection<OrganStruct> OrganStruct { get; set; }

        public virtual ICollection<Role> Role { get; set; }
        
        public virtual ICollection<WorkFlowProcess> WorkFolwProcess { get; set; }

        public virtual ICollection<WorkFlowRequestForm> WorkFolwRequestForm1 { get; set; }

        public virtual ICollection<WorkFlowRequestForm> WorkFlowRequestForm2 { get; set; }

        public virtual ICollection<WorkFlowWorkNodes> WorkFolwWorkNodes1 { get; set; }

        public virtual ICollection<WorkFlowWorkNodes> WorkFolwWorkNodes2 { get; set; }


    }
}
