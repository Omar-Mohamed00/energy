using energy.Models;
using Microsoft.EntityFrameworkCore;

namespace energy.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Device1> device1 {  get; set; }
        public DbSet<Device2> device2 {  get; set; }
    }
}
