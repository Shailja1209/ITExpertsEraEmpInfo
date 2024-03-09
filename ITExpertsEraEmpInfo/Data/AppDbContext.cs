using ITExpertsEraEmpInfo.Models;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace ITExpertsEraEmpInfo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
