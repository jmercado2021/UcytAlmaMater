using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Titulos
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Titulos> GetAll()
        {
            var titulos = _dtx.Titulos.ToList();
            titulos.Insert(0, new BlackSys.Models.Dal.Titulos { Id = 0, Descripcion = "Seleccione una opción" });
            return titulos;
        }
        public BlackSys.Models.Dal.Titulos GetById(int id)
        {
            return _dtx.Titulos.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}