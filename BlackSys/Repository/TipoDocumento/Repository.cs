using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.TipoDocumento
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.TipoDocumento> GetAll()
        {

            var tipoDocumentos = _dtx.TipoDocumento.ToList();
            tipoDocumentos.Insert(0, new BlackSys.Models.Dal.TipoDocumento { Id = 0, Descripcion = "Seleccione una opción" });
            return tipoDocumentos;
     
        }


        public BlackSys.Models.Dal.TipoDocumento GetById(int id)
        {
            return _dtx.TipoDocumento.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}