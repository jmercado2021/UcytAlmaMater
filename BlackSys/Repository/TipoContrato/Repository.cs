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
            return _dtx.TipoContrato.ToList();
        }
        public BlackSys.Models.Dal.TipoContrato GetById(int id)
        {
            return _dtx.TipoContrato.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}