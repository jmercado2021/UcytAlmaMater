using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.NivelFormacion
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.NivelFormacion> GetAll();
        BlackSys.Models.Dal.NivelFormacion GetById(int id);

    }
}
