using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.EjercicioDirectivo
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.EjercicioDirectivo> GetAll();
        BlackSys.Models.Dal.EjercicioDirectivo GetById(int id);

    }
}
