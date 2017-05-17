using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dream.Model.Models
{
    public class WorkFlowWorkNodes
    {
        public WorkFlowWorkNodes()
        {
            this.WorkFlowProcess = new HashSet<WorkFlowProcess>();
            this.WorkFlowWorkBranch = new HashSet<WorkFlowWorkBranch>();
        }

        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string WorkFlowId { get; set; }
        [MaxLength(10)]
        [Required]
        public int WorkFlowOrderNo { get; set; }
        [MaxLength(40)]
        [Required]
        public string Type { get; set; }
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }
        [MaxLength(50)]
        [Required]
        public string BizMethod { get; set; }
        [MaxLength(50)]
        [Required]
        public decimal MaxNum { get; set; }
        [MaxLength(40)]
        [Required]
        public string RoleType { get; set; }

        [MaxLength(50)]
        public Nullable<int> Ext1 { get; set; }

        [MaxLength(50)]
        [Required]
        public string Ext2 { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }

        public DateTime CreateTime { get; set; }
        [MaxLength(40)]
        [Required]
        public string UpdateId { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual KeyValue KeyValue1 { get; set; }

        public virtual KeyValue KeyValue2 { get; set; }

        public virtual ICollection<WorkFlowProcess> WorkFlowProcess { get; set; }
        public virtual WorkFlowWork WorkFlowfWork { get; set; }

        public virtual ICollection<WorkFlowWorkBranch> WorkFlowWorkBranch { get; set; }

    }
}
