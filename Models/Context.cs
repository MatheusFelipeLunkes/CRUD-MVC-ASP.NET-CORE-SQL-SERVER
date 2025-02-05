using Microsoft.EntityFrameworkCore;
using ProductModel;

namespace CRUDCompleto.Models.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) {
        }
        
    public DbSet<Product> Product { get; set; }
    }
}
