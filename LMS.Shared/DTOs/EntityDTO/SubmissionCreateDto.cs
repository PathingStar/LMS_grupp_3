using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Shared.DTOs.EntityDTO
{
    public class SubmissionCreateDto
    {
        public Guid DocumentId { get; set; }   // The ID of the document being submitted
        public string UserId { get; set; } = string.Empty; // The ID of the user submitting the document
        //public IFormFile File { get; set; } = default!;   // The file being uploaded
    }
}
