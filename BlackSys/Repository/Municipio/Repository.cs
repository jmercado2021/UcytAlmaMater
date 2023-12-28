using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Municipio
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Municipio> GetAll()
        {
            var municipio = _dtx.Municipio.OrderBy(t => t.Descripcion).ToList();
            municipio.Insert(0, new BlackSys.Models.Dal.Municipio { Id = 0, Descripcion = "Seleccione una opción" });
            return municipio;
        }
        public BlackSys.Models.Dal.Municipio GetById(int id)
        {
            return _dtx.Municipio.Where(t => t.Id == id).FirstOrDefault();
        }
        public  List<BlackSys.Models.Dal.Municipio> GetByDepId(int id)
        {
            return _dtx.Municipio.Where(t => t.DepartamentoId == id).ToList();
        }
    }
}