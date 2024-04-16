using mvcProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoWeb.AccesoDatos.Data.IRepository
{
    public interface IAlmacenRepository : IRepository<Almacen>
    {
        void Update(Almacen almacen);
    }
}

