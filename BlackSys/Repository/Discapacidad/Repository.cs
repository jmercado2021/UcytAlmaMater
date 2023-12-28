using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Discapacidad
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Discapacidad> GetAll()
        {
            var area = _dtx.Discapacidad.ToList();
            area.Insert(0, new BlackSys.Models.Dal.Discapacidad { Id = 0, Descripcion = "Seleccione una opción" });
            return area;
        }
        public BlackSys.Models.Dal.Discapacidad GetById(int id)
        {
            return _dtx.Discapacidad.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}