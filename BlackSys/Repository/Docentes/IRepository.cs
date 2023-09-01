using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackSys.Models.Dal;

namespace BlackSys.Repository.Docentes
{
    public interface IRepository
    {
        List<Docente> GetAll();
        Docente GetById(int id);
        List<Docente> FindByName(string Nombre);
    }
}
