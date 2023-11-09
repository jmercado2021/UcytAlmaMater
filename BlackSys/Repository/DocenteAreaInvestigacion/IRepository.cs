using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.DocenteAreaInvestigacion
{
  public  interface IRepository
    {
        List<BlackSys.Models.Dal.DocenteAreaInvestigacion> GetAll();
        BlackSys.Models.Dal.DocenteAreaInvestigacion GetById(int id);
    }
}
