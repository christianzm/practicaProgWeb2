using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoWeb.AccesoDatos.Data.IRepository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _context;
        public ContenedorTrabajo(ApplicationDbContext context)
        {
            _context = context;
            //se agregan cada uno de los repositorios para que queden encapsulados
            Almacan = new AlmacenRepository(_context);
        }

        public IAlmacenRepository Almacan { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
