using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Recinto
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Recinto> GetAll()
        {
            return _dtx.Recinto.ToList();
        }
        public BlackSys.Models.Dal.Recinto GetById(int id)
        {
            return _dtx.Recinto.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}