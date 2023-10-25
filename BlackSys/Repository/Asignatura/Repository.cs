using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Asignatura
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Asignatura> GetAll()
        {
            return _dtx.Asignatura.OrderBy(t=> t.Nombre).ToList();
        }
        public BlackSys.Models.Dal.Asignatura GetById(int id)
        {
            return _dtx.Asignatura.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}