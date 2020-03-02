using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.io.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string Creator { get; set; }
        public string Source { get; set; }
        public string Organaizer { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }
    }
}
