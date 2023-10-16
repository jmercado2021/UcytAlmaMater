using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.NivelFormacion
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.NivelFormacion> GetAll()
        {
            return _dtx.NivelFormacion.ToList();
        }
        public BlackSys.Models.Dal.NivelFormacion GetById(int id)
        {
            return _dtx.NivelFormacion.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}