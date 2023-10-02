using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Area
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Area> GetAll();
        BlackSys.Models.Dal.Area GetById(int id);

    }
}
