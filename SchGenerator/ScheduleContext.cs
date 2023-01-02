using SchGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace SchGenerator
{
    public class ScheduleContext : DbContext
    {
        public DbSet<ActualSchedule> ActualSchedules { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=VLAD;Initial Catalog=ScheduleDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
