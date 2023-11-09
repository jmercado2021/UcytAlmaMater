using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.DocenteAreaInvestigacion
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.DocenteAreaInvestigacion> GetAll()
        {
            var cargo = _dtx.DocenteAreaInvestigacion.OrderBy(t => t.Descripcion).ToList();
            cargo.Insert(0, new BlackSys.Models.Dal.DocenteAreaInvestigacion { Id = 0, Descripcion = "Seleccione una opción" });
            return cargo;
           
        }
        public BlackSys.Models.Dal.DocenteAreaInvestigacion GetById(int id)
        {
            return _dtx.DocenteAreaInvestigacion.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}