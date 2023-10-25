using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Pais
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Pais> GetAll()
        {
            var pais = _dtx.Pais.ToList();
            pais.Insert(0, new BlackSys.Models.Dal.Pais { Id = 0, Descripcion = "Seleccione una opción" });
            return pais;
        }
        public BlackSys.Models.Dal.Pais GetById(int id)
        {
            return _dtx.Pais.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}