using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Region
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Municipio> GetAllByDepId(int Id)
        {
            var data = _dtx.Municipio.Where(t => t.DepartamentoId==Id).ToList();
            data.Insert(0, new BlackSys.Models.Dal.Municipio { Id = 0, Descripcion = "Seleccione una opción" });
            return data;
        }
        //public BlackSys.Models.Dal.Recinto GetById(int id)
        //{
        //    return _dtx.Recinto.Where(t => t.Id == id).FirstOrDefault();
        //}
    }
}