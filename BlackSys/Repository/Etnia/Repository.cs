using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Etnia
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Etnia> GetAll()
        {
            var etnia = _dtx.Etnia.OrderBy(t => t.Descripcion).ToList();
            etnia.Insert(0, new BlackSys.Models.Dal.Etnia { Id = 0, Descripcion = "Seleccione una opción" });
            return etnia;
        }
        public BlackSys.Models.Dal.Etnia GetById(int id)
        {
            return _dtx.Etnia.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}