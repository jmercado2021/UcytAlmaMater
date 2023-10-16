using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Titulos
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Titulos> GetAll();
        BlackSys.Models.Dal.Titulos GetById(int id);

    }
}
