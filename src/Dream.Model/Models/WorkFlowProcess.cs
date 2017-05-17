using System;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    public class WorkFlowProcess
    {
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string WorkFlowRequestFormId { get; set; }
        [MaxLength(40)]
        [Required]
        public string Processor { get; set; }
        [MaxLength(2)]
        [Required]
        public int WorkFlowRequestFormStatus { get; set; }
        [MaxLength(240)]
        [Required]
        public string Description { get; set; }
        [MaxLength(40)]
        [Required]
        public string WorkFlowWorkNodesId { get; set; }
        [MaxLength(240)]
        [Required]
        public string Ext1 { get; set; }
        [MaxLength(40)]
        [Required]
        public Nullable<int> Ext2 { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual KeyValue KeyValue { get; set; }
        public virtual WorkFlowRequestForm WorkFlowRequestForm { get; set; }
        public virtual WorkFlowWorkNodes WorkFlowWorkNodes { get; set; }
      
    }
}
