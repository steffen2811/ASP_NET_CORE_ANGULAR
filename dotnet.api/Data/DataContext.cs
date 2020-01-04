using dotnet.api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){  }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photes { get; set; }
    }
}