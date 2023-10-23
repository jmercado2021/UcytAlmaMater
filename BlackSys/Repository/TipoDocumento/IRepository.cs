using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSys.Repository.TipoDocumento
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.TipoDocumento> GetAll();
        BlackSys.Models.Dal.TipoDocumento GetById(int id);

    }
}
