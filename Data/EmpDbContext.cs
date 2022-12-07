using Microsoft.EntityFrameworkCore;
using RazorPageUploadImgTest.Models;

namespace RazorPageUploadImgTest.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext (DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Employee> Employees { get; set;} 
    }
}
