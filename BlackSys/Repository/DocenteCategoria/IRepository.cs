using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.DocenteCategoria
{
  public  interface IRepository
    {
        List<BlackSys.Models.Dal.DocenteCategoria> GetAll();
        BlackSys.Models.Dal.DocenteCategoria GetById(int id);
    }
}
