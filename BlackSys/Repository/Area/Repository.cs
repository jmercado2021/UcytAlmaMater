using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Area
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Area> GetAll()
        {
            var area = _dtx.Area.ToList();
            area.Insert(0, new BlackSys.Models.Dal.Area { Id = 0, Descripcion = "Seleccione una opción" });
            return area;
        }
        public BlackSys.Models.Dal.Area GetById(int id)
        {
            return _dtx.Area.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}