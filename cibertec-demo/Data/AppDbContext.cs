using cibertec_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace cibertec_demo.Data
{
    public class AppDbContext : DbContext
    {//es un contrato para ver q entidades van en el scafolding
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
