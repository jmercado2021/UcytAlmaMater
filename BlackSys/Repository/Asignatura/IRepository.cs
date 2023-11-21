using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackSys.Models.Dal;

namespace BlackSys.Repository.Asignatura
{
   public interface IRepository
    {
        List<BlackSys.Models.Dal.Asignatura> GetAll();
        BlackSys.Models.Dal.Asignatura GetById(int id);
        List<BlackSys.Models.Dal.Asignatura> FindByName(string Nombre);
        void Update(Models.Dal.Asignatura model);
        void Add(Models.Dal.Asignatura model);

    }
}
