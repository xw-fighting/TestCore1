using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    public class WorkFlowWork
    {
        public WorkFlowWork()
        {
            this.WorkFlowRequestForm = new HashSet<WorkFlowRequestForm>();
            this.WorkFlowWorkNodes = new HashSet<WorkFlowWorkNodes>();
        }

        [Key]
        [StringLength(40)]
        public string Id { get; set; }
        [MaxLength(120)]
        [Required]
        public string Title { get; set; }
        [MaxLength(4)]
        [Required]
        public int Status { get; set; }
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
        
        public virtual ICollection<WorkFlowRequestForm> WorkFlowRequestForm { get; set; }
        
        public virtual ICollection<WorkFlowWorkNodes> WorkFlowWorkNodes { get; set; }
    }
}

