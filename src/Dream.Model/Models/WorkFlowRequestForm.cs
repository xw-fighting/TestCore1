using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dream.Model.Models
{
    public class WorkFlowRequestForm
    {
        public WorkFlowRequestForm()
        {
            this.WorkFlowProcess = new HashSet<WorkFlowProcess>();
        }

        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string WorkFlowWorkId { get; set; }
        [MaxLength(140)]
        [Required]
        public string Title { get; set; }
        [MaxLength(240)]
        [Required]
        public string Remark { get; set; }
        [MaxLength(40)]
        [Required]
        public string Priority { get; set; }
        [MaxLength(2)]
        [Required]
        public string Status { get; set; }
        [MaxLength(140)]
        [Required]
        public string Ext1 { get; set; }
        [MaxLength(40)]
        [Required]
        public Nullable<int> Ext2 { get; set; }
        [MaxLength(40)]
        [Required]
        public string LogicSymbol { get; set; }
        [MaxLength(40)]
        [Required]
        public decimal Num { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual KeyValue KeyValue1 { get; set; }

        public virtual KeyValue KeyValue2 { get; set; }
        public virtual UserManageInfo UserManageInfo { get; set; }
        public virtual ICollection<WorkFlowProcess> WorkFlowProcess { get; set; }
        public virtual WorkFlowWork WorkFlowWork { get; set; }
    }
}
