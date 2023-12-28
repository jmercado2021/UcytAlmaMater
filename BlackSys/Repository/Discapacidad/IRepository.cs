using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Discapacidad
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Discapacidad> GetAll();
        BlackSys.Models.Dal.Discapacidad GetById(int id);

    }
}
