using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackSys.Models;
using BlackSys.Models.Dal;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace BlackSys.Repository.Asignatura
{
    public class Repository : IRepository
    {
        private readonly UcytAlmaMaterEntities _dtx = new UcytAlmaMaterEntities();
        private readonly Helper _helper = new Helper();
        private ModelStateDictionary _modelstate;
        
        public Repository(ModelStateDictionary modelstate)
        {
            _modelstate = modelstate;
        }
        public List<BlackSys.Models.Dal.Asignatura> GetAll()
        {
            return _dtx.Asignatura.OrderBy(t=> t.Nombre).ToList();
        }
        public BlackSys.Models.Dal.Asignatura GetById(int id)
        {
            return _dtx.Asignatura.Where(t => t.Id == id).FirstOrDefault();
        }
        public List<BlackSys.Models.Dal.Asignatura> FindByName(string Nombre)
        {
            return _dtx.Asignatura.Where(x => x.Nombre.Contains("Nombre")).ToList();
        }
        public void Update(BlackSys.Models.Dal.Asignatura model)
        {      
            BlackSys.Models.Dal.Asignatura data = GetById(model.Id);
            data.Nombre = model.Nombre;
            data.NotaMaxExtraDerecho = model.NotaMaxExtraDerecho;
            data.NotaMinConvalidacion = model.NotaMinConvalidacion;
            data.NotaMinExtraDerecho = model.NotaMinExtraDerecho;
            data.NotaMinRegular = model.NotaMinRegular;
            data.NotaMinSuficiencia = model.NotaMinSuficiencia;
            data.NotaMinTutoria = model.NotaMinTutoria;
            data.FechaModifica = DateTime.Now;
            data.Activo = model.Activo;
            data.UsuarioModifica = _helper.GetUserName();
            data.Activo = model.Activo;
            _dtx.SaveChanges();

        }
        public void Add(BlackSys.Models.Dal.Asignatura model)
        {
            BlackSys.Models.Dal.Asignatura data = new Models.Dal.Asignatura(); 
            data.Nombre = model.Nombre;
            data.NotaMaxExtraDerecho = model.NotaMaxExtraDerecho;
            data.NotaMinConvalidacion = model.NotaMinConvalidacion;
            data.NotaMinExtraDerecho = model.NotaMinExtraDerecho;
            data.NotaMinRegular = model.NotaMinRegular;
            data.NotaMinSuficiencia = model.NotaMinSuficiencia;
            data.NotaMinTutoria = model.NotaMinTutoria;
            data.FechaModifica = DateTime.Now;
            data.Activo = model.Activo;
            data.UsuarioModifica = _helper.GetUserName();
            data.Identificador = model.Identificador;
            _dtx.Asignatura.Add(data);
            _dtx.SaveChanges();

        }
    }
}