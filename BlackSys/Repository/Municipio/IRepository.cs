using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Municipio
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Municipio> GetAll();
        BlackSys.Models.Dal.Municipio GetById(int id);
        List<BlackSys.Models.Dal.Municipio> GetByDepId(int id);

    }
}
