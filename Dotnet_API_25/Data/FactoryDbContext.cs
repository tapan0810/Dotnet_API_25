using Dotnet_API_25.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_25.Data
{
    public class FactoryDbContext:DbContext
    {
        public FactoryDbContext(DbContextOptions<FactoryDbContext> options) : base(options) { }

        public DbSet<Factory>Factories =>Set<Factory>();

        public DbSet<User> Users => Set<User>();
    }
}
