using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerPilot.API.Models
{
    public class Users
    {
        public int Id { get; set; }
        public int UserName { get; set; }
        public int PasswordHash { get; set; }
    }
}