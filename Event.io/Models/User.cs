using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.io.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Photo { get; set; }
        public string Faculty { get; set; }
        public string Course { get; set; }
        public string Specialty { get; set; }
    }
}
