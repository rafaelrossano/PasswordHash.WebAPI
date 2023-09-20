using Microsoft.EntityFrameworkCore;
using PasswordHash.WebAPI.Entities;

namespace PasswordHash.WebAPI.Data


{
    public sealed class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    
        public DbSet<User> Users { get; set; }
    }
}
