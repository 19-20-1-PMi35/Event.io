using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Event.io.Models
{
    public class EventContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Semester> Semesters { get; set; }

        public EventContext(DbContextOptions<EventContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
