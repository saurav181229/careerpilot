using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CareerPilot.API.Models
{
    public class Resume
    {
        public int Id { get; set; }
        [Key]
        public int UserId { get; set; }
    public string FileName { get; set; } = default!;
    public string FilePath { get; set; } = default!;
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}