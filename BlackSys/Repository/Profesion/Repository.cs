using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Profesion
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Profesion> GetAll()
        {
            return _dtx.Profesion.ToList();
        }
        public BlackSys.Models.Dal.Profesion GetById(int id)
        {
            return _dtx.Profesion.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}