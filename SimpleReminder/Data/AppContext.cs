using Microsoft.EntityFrameworkCore;
using SimpleReminder.Models;

namespace SimpleReminder.Data
{
    public class AppContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        public AppContext(DbContextOptions<AppContext>options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
