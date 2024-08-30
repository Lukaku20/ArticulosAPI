using Microsoft.EntityFrameworkCore;
using ArticulosAPI.Models;

namespace ArticulosAPI.Data
{
    public class ArticulosContext : DbContext
    {
        public ArticulosContext(DbContextOptions<ArticulosContext> options)
            : base(options)
        {
        }

        public DbSet<Articulo> Articulos { get; set; }
    }
}
