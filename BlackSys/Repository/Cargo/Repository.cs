using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Cargo
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Cargo> GetAll()
        {
            var cargo = _dtx.Cargo.ToList();
            cargo.Insert(0, new BlackSys.Models.Dal.Cargo { Id = 0, Descripcion = "Seleccione una opción" });
            return cargo;
           
        }
        public BlackSys.Models.Dal.Cargo GetById(int id)
        {
            return _dtx.Cargo.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}