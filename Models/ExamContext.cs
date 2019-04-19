using Microsoft.EntityFrameworkCore;
 
namespace ExamBelt.Models
{
    public class ExamContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public ExamContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get; set;}
        public DbSet<AnActivity> Activities {get; set;}
        public DbSet<Participant> Participants {get; set;}
    }
}