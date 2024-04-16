using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcProyectoWeb.Models;

namespace mvcProyectoWeb.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Poner aquí todos los modelos que se vayan creando
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Almacen> Almacen { get; set; }
    }
}
