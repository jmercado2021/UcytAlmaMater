using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Cargo
{
  public  interface IRepository
    {
        List<BlackSys.Models.Dal.Cargo> GetAll();
        BlackSys.Models.Dal.Cargo GetById(int id);
    }
}
