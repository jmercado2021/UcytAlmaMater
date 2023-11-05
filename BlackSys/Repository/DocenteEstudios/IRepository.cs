using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.DocenteEstudios
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.DocenteEstudios> GetAll();
        BlackSys.Models.Dal.DocenteEstudios GetById(int id);

    }
}
