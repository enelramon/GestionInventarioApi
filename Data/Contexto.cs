using GestionInventarioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionInventarioApi.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Articulos> Articulos { get; set; }
    }
}
