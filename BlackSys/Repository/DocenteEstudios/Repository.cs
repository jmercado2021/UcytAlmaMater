using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.DocenteEstudios
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.DocenteEstudios> GetAll()
        {
            var data = _dtx.DocenteEstudios.OrderBy(t => t.Descripcion).ToList();
            data.Insert(0, new BlackSys.Models.Dal.DocenteEstudios { Id = 0, Descripcion = "Seleccione una opción" });
            return data;
        }
        public BlackSys.Models.Dal.DocenteEstudios GetById(int id)
        {
            return _dtx.DocenteEstudios.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}