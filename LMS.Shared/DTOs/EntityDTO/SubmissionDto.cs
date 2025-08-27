using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Shared.DTOs.EntityDTO
{
    public class SubmissionDto
    {
        public Guid Id { get; set; }
        public Guid DocumentId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; }
    }
}
