using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.TipoContrato
{
  public  interface IRepository
    {
        List<BlackSys.Models.Dal.TipoContrato> GetAll();
        BlackSys.Models.Dal.TipoContrato GetById(int id);
    }
}
