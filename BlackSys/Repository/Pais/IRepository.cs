using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Pais
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Pais> GetAll();
        BlackSys.Models.Dal.Pais GetById(int id);

    }
}
