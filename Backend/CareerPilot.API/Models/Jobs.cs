using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CareerPilot.API.Models
{
    public class Jobs
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        public int ResumeId{ get; set; }
    public string Title { get; set; } = default!;
    public string Company { get; set; } = default!;
    public string Status { get; set; } = "Applied";
    public DateTime AppliedDate { get; set; } = DateTime.UtcNow;
    }
}