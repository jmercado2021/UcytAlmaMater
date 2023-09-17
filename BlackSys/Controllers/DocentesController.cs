using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models.Dal;
using BlackSys.Models.ViewModel;
using Newtonsoft;
using Newtonsoft.Json;
using static BlackSys.Models.Enum.ClEnum;

namespace BlackSys.Controllers
{
    public class DocentesController : Controller
    {
        private Repository.Docentes.IRepository _docenteRepositoy;
        private Repository.Departamento.IRepository _departamento;
        private Repository.Municipio.IRepository _municipio;
        private Repository.Etnia.IRepository _etnia;
        private Repository.Pais.IRepository _pais;
        private Repository.TipoContrato.IRepository _tipoContrato;
        private Repository.Cargo.IRepository _cargo;
        private Repository.Asignatura.IRepository _Asignatura;
        public DocentesController()
        {
            _docenteRepositoy = new Repository.Docentes.Repository(this.ModelState);
            _departamento = new Repository.Departamento.Repository(this.ModelState);
            _municipio = new Repository.Municipio.Repository(this.ModelState);
            _etnia = new Repository.Etnia.Repository(this.ModelState);
            _pais = new Repository.Pais.Repository(this.ModelState);
            _tipoContrato = new Repository.TipoContrato.Repository(this.ModelState);
            _cargo = new Repository.Cargo.Repository(this.ModelState);
            _Asignatura = new Repository.Asignatura.Repository(this.ModelState);
        }
        // GET: Docentes
        public ActionResult Index()
        {
            return View(_docenteRepositoy.GetAll());
        }

    // GET: Docentes/Details/5
        public ActionResult ParcialListado(string Nombre)
        {
            return PartialView(_docenteRepositoy.FindByName(Nombre));
        }
        public ActionResult Details (int id)
        {

            var enumData = from Gender e in Enum.GetValues(typeof(Gender))
                           select new
                           {
                               Id = (int)e,
                               Descripcion = e.ToString()
                           };
            var lscivilstatus = from CivilStatus e in Enum.GetValues(typeof(CivilStatus))
                           select new
                           {
                               Id = (int)e,
                               Descripcion = e.ToString()
                           };
            var lstrueFalse= from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                                select new
                                {
                                    Id = (int)e,
                                    Descripcion = e.ToString()
                                };


            DocenteViewModel docenteView = new DocenteViewModel();
            docenteView.docente = _docenteRepositoy.GetById(id);
            ViewBag.Departamento = new SelectList(_departamento.GetAll(), "Id", "Descripcion");
            ViewBag.Municipio = new SelectList(_municipio.GetAll(), "Id", "Descripcion");
            ViewBag.Etnia = new SelectList(_etnia.GetAll(), "Id", "Descripcion");
            ViewBag.Pais = new SelectList(_pais.GetAll(), "Id", "Descripcion");
            ViewBag.Sexo = new SelectList(enumData, "Id", "Descripcion");
            ViewBag.CivilStatus = new SelectList(lscivilstatus, "Id", "Descripcion");
            ViewBag.Estudia = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.FormacionPedadogica = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.TipoContrato = new SelectList(_tipoContrato.GetAll(), "Id", "Descripcion");
            ViewBag.Cargo = new SelectList(_cargo.GetAll(), "Id", "Descripcion");
            docenteView.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(id);
            //ViewBag.Asignaturas = docenteView.asignaturasView;
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");
            return View(docenteView);
            //}
        }
        [HttpPost]
        public ActionResult Details(DocenteViewModel docente)
        {
            //if (_docenteRepositoy.Update(docente))
            //{
            //    return Json("Ok");
            //}
            //HttpContext.Response.StatusCode = 500;
            //    HttpContext.Response.StatusDescription = JsonConvert.SerializeObject(ModelState.Values.SelectMany(m => m.Errors)
            //        .Select(e => e.ErrorMessage.Truncate(500))
            //          .ToList());
            //HttpContext.Response.Clear();
            //return PartialView("Details", docente);

            if (ModelState.IsValid)
            {
                if (_docenteRepositoy.Update(docente.docente))
                {
                    _docenteRepositoy.Save();
                }
                //_docenteRepositoy.Update(docente);
               

               
            }
            return View(docente);
            //return View();
            //}
        }

        public ActionResult _AddSubjectDocente(int DocenteId, int? AsignaturaId)
        {
            var dataDocente= _docenteRepositoy.GetById(DocenteId);
            DocenteViewModel docenteView = new DocenteViewModel();
            docenteView.docente = dataDocente;
           
            
            if (AsignaturaId.HasValue)
            {
                var asig = _docenteRepositoy.GetSubjectDocente(dataDocente, Convert.ToInt32(AsignaturaId));
                if (asig.Count > 0)
                {
                    ModelState.AddModelError("","Ya existe la asignatura asociada");
                }
                else
                {
                    _docenteRepositoy.AddSubject(dataDocente, Convert.ToInt32(AsignaturaId));

                }
               
            }
            docenteView.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(DocenteId);
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");
            return View("_AddSubjectDocente", docenteView);
        }

        
  
        public ActionResult AddSubjectDocente(int DocenteId, int AsignaturaId)
        {
            
            return View();
        }

        // POST: Docentes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Docentes/Edit/5
        public PartialViewResult _PartialAsignaturasDocente(int DocenteId)
        {
            var data = _docenteRepositoy.LoadDocenteAsignatura(DocenteId);
            return PartialView("_AsignaturasDocentes",data);
        }

        // POST: Docentes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Docentes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Docentes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
