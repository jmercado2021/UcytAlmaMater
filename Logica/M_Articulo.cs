using System;
using System.Collections.Generic;
using System.Text;
using BlackSys.Models;

namespace Logica
{
    class M_Articulo
    {
        private COMERCIALEntities db = new COMERCIALEntities();
        public List<TblArticulo> Buscar(string Nombre)
        {

       
                var productos = db.TblArticulo.OrderBy(x => x.Nombre)
                                        .Where(x => x.Nombre.Contains(nombre))
                                        .Take(10)
                                        .ToList();

                return productos;
         

        }
    }
}
