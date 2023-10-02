using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Profesion
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Profesion> GetAll();
        BlackSys.Models.Dal.Profesion GetById(int id);

    }
}
