using APIMySQL.Model;
using Microsoft.EntityFrameworkCore;

namespace APIMySQL.Data
{
    public class APIDBContext : DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> options) : base(options) { 
        
        }

        public DbSet<Estado> Estado { get; set; }
    }
}
