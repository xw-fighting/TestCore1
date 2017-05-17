using System;
using System.ComponentModel.DataAnnotations;

namespace Dream.Model.Models
{
    public class WorkFlowWorkBranch
    {
        [Key]
        [MaxLength(40)]
        [Required]
        public string Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string WorkFlowNodeToken { get; set; }
        [MaxLength(40)]
        [Required]
        public string WorkFlowWorkNodesId { get; set; }
        [MaxLength(40)]
        [Required]
        public string CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        [MaxLength(40)]
        [Required]
        public string UpdateId { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual WorkFlowWorkNodes WorkFlowWorkNodes { get; set; }
    }
}
