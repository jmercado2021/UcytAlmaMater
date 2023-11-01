using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.TipoContrato
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.TipoContrato> GetAll()
        {
            var tipoContrato = _dtx.TipoContrato.OrderBy(t => t.Descripcion).ToList();
            tipoContrato.Insert(0, new BlackSys.Models.Dal.TipoContrato { Id = 0, Descripcion = "Seleccione una opción" });
            return tipoContrato;
        }
        public BlackSys.Models.Dal.TipoContrato GetById(int id)
        {
            return _dtx.TipoContrato.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}