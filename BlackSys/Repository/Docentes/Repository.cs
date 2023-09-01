﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Repository;
using Microsoft.AspNet.Identity;
using BlackSys.Models;
using BlackSys.Models.Dal;
using System.Web.Mvc;


namespace BlackSys.Repository.Docentes
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private ModelStateDictionary _modelstate;
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<Docente> GetAll()
        {
            return _dtx.Docente.ToList();
        }
        public Docente GetById(int id)
        {
            return _dtx.Docente.Where(t => t.Id==id).FirstOrDefault();
        }
        public List<Docente> FindByName(string Nombre)
        {
            return _dtx.Docente.Where(x => x.Nombre.Contains("Nombre")).ToList();
        }

    }
}