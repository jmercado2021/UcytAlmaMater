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
            var nivelFormacion = _dtx.NivelFormacion.ToList();
            nivelFormacion.Insert(0, new BlackSys.Models.Dal.NivelFormacion { Id = 0, Descripcion = "Seleccione una opción" });
            return nivelFormacion;
        }
        public BlackSys.Models.Dal.NivelFormacion GetById(int id)
        {
            return _dtx.NivelFormacion.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}