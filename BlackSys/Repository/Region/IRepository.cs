using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.Region
{
  public  interface IRepository
    {
        List<BlackSys.Models.Dal.Municipio> GetAllByDepId(int Id);
    }
}
