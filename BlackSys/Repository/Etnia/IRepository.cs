using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Etnia
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Etnia> GetAll();
        BlackSys.Models.Dal.Etnia GetById(int id);

    }
}
