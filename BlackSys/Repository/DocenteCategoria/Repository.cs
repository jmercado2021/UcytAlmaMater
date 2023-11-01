using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.DocenteCategoria
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.DocenteCategoria> GetAll()
        {
            var cargo = _dtx.DocenteCategoria.OrderBy(t => t.Descripcion).ToList();
            cargo.Insert(0, new BlackSys.Models.Dal.DocenteCategoria { Id = 0, Descripcion = "Seleccione una opción" });
            return cargo;
           
        }
        public BlackSys.Models.Dal.DocenteCategoria GetById(int id)
        {
            return _dtx.DocenteCategoria.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}