﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models.Dal;
using System.Web.Mvc;

namespace BlackSys.Repository.Departamento
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Departamento> GetAll()
        {
            return _dtx.Departamento.ToList();
        }
        public BlackSys.Models.Dal.Departamento GetById(int id)
        {
            return _dtx.Departamento.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}