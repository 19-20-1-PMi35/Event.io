using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.io.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }
    }
}
