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
        bool Update(Docente docente);
        List<Docente> FindByName(string Nombre);
        List<ViewDocenteAsignatura> GetSubjectDocente(Docente model, int AsignaturaId);
        List<ViewDocenteAsignatura> LoadDocenteAsignatura(int id);
        bool AddSubject(Docente model, int AsignaturaId);
        void Save();
    }
}
