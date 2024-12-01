using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using AmbyrDevelops.DataTransferObjects;

namespace AmbyrDevelops.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<PageDTO> PageSections { get; set; }
    }
}
