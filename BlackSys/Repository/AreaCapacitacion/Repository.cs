﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.AreaCapacitacion
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.AreaCapacitacion> GetAll()
        {
            var data = _dtx.AreaCapacitacion.OrderBy(t => t.Descripcion).ToList();
            data.Insert(0, new BlackSys.Models.Dal.AreaCapacitacion { Id = 0, Descripcion = "Seleccione una opción" });
            return data;
        
        }
        public BlackSys.Models.Dal.AreaCapacitacion GetById(int id)
        {
            return _dtx.AreaCapacitacion.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}