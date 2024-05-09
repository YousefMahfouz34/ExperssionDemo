using ExperssionTreeInRunTimeDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ExperssionTreeInRunTimeDemo.Context
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext>options):base(options) { }
        public DbSet<Empolyee> empolyees { get; set; }
        public DbSet<Department> departments { get; set; }

    }
}
