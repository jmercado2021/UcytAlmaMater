using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Recinto
{
  public  interface IRepository
    {
        List<BlackSys.Models.Dal.Recinto> GetAll();
        BlackSys.Models.Dal.Recinto GetById(int id);
    }
}
