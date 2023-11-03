using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models.Dto;
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
        private Repository.Profesion.IRepository _profesion;
        private Repository.Area.IRepository _area;
        private Repository.Recinto.IRepository _recinto;
        private Repository.NivelFormacion.IRepository _nivelformacion;
        private Repository.Titulos.IRepository _titulo;
        private Repository.TipoDocumento.IRepository _tipodocumento;
        private Repository.DocenteCategoria.IRepository _docenteCateg;
        private Repository.EjercicioDirectivo.IRepository _ejercDirec;
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
            _profesion = new Repository.Profesion.Repository(this.ModelState);
            _area = new Repository.Area.Repository(this.ModelState);
            _recinto = new Repository.Recinto.Repository(this.ModelState);
            _nivelformacion = new Repository.NivelFormacion.Repository(this.ModelState);
            _titulo = new Repository.Titulos.Repository(this.ModelState);
            _tipodocumento = new Repository.TipoDocumento.Repository(this.ModelState);
            _docenteCateg = new Repository.DocenteCategoria.Repository(this.ModelState);
            _ejercDirec = new Repository.EjercicioDirectivo.Repository(this.ModelState);
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

            var enumData = from Gender e in Enum.GetValues(typeof(Gender))select new
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

      
        //var lsEjercicioDirectivo = from EjercicioDirectivo e in Enum.GetValues(typeof(CivilStatus))
        //                    select new
        //                    {
        //                        Id = (int)e,
        //                        Descripcion = e.ToString()
        //                    };


        var lszona = from Zona e in Enum.GetValues(typeof(Zona))
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
            ViewBag.SINO = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.FormacionPedadogica = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.TipoContrato = new SelectList(_tipoContrato.GetAll(), "Id", "Descripcion");
            ViewBag.Cargo = new SelectList(_cargo.GetAll(), "Id", "Descripcion");
            ViewBag.ProfesionV = new SelectList(_profesion.GetAll(), "Id", "Descripcion");
            ViewBag.AreaV = new SelectList(_area.GetAll(), "Id", "Descripcion");
            ViewBag.NivelFormacionV = new SelectList(_nivelformacion.GetAll(), "Id", "Descripcion");
            ViewBag.TituloV = new SelectList(_titulo.GetAll(), "Id", "Descripcion");
            ViewBag.TipoDocumentoV = new SelectList(_tipodocumento.GetAll(), "Id", "Descripcion", selectedValue: null);
            docenteView.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(id);
            ViewBag.CatDocenteV = new SelectList(_docenteCateg.GetAll(), "Id", "Descripcion");
            ViewBag.ZonaV = new SelectList(lszona, "Id", "Descripcion");
            ViewBag.EjercicioDirectivoV = new SelectList(_ejercDirec.GetAll(), "Id", "Descripcion");
            
            //ViewBag.Asignaturas = docenteView.asignaturasView;
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");
            return View(docenteView);
            //}
        }
        [HttpPost]
        public ActionResult Details(DocenteViewModel model)
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
            var lstrueFalse = from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                              select new
                              {
                                  Id = (int)e,
                                  Descripcion = e.ToString()
                              };

            //model.docente.Estudia = "SI" ? model.docente.Estudia = false : model.docente.Estudia = true; 

            DocenteViewModel docenteView = new DocenteViewModel();
            docenteView.docente = _docenteRepositoy.GetById(model.docente.Id);

            ViewBag.Departamento = new SelectList(_departamento.GetAll(), "Id", "Descripcion");
            ViewBag.Municipio = new SelectList(_municipio.GetAll(), "Id", "Descripcion");
            ViewBag.Etnia = new SelectList(_etnia.GetAll(), "Id", "Descripcion");
            ViewBag.Pais = new SelectList(_pais.GetAll(), "Id", "Descripcion");
            ViewBag.Sexo = new SelectList(enumData, "Id", "Descripcion");
            ViewBag.CivilStatus = new SelectList(lscivilstatus, "Id", "Descripcion");
            ViewBag.SINO = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.FormacionPedadogica = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.TipoContrato = new SelectList(_tipoContrato.GetAll(), "Id", "Descripcion");
            ViewBag.Cargo = new SelectList(_cargo.GetAll(), "Id", "Descripcion");
            ViewBag.ProfesionV = new SelectList(_profesion.GetAll(), "Id", "Descripcion");
            ViewBag.AreaV = new SelectList(_area.GetAll(), "Id", "Descripcion");
            ViewBag.NivelFormacionV = new SelectList(_nivelformacion.GetAll(), "Id", "Descripcion");
            ViewBag.TituloV = new SelectList(_titulo.GetAll(), "Id", "Descripcion");
            ViewBag.TipoDocumentoV = new SelectList(_tipodocumento.GetAll(), "Id", "Descripcion");
            model.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(model.docente.Id);
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");
            //Validaciones
            if (model.docente.Nombre ==null)
            {
                ModelState.AddModelError("", "Nombre no puede quedar vacio, Por favor registre el nombre del Docente ");
                return View(model);
            }

            //ModelState.AddModelError("", "Existenen errores en datos ingresados, Por favor verifique los campos marcados en rojo ");
            //return View(viewmodel);
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (_docenteRepositoy.Update(model.docente))
                {
                    _docenteRepositoy.Save();
                }
                //_docenteRepositoy.Update(docente);
           
            return View(model);
            //return View();
            //}
        }
        [HttpPost]
        public JsonResult NAddSubjectDocente(DtoDocenteAsignatura docente)
        {
           if (AddSubjectDocente(docente.DocenteId, docente.AsignaturaId))
            { 
                bool success = true;
            return Json(new { success = success });
            }
            //return Json("'success':'true'");
            else
               return Json(String.Format("'success':'false','Error':'Ha habido un error al insertar el registro.'"));
        }

        public ActionResult AgregarDocente (int? Id)
        {
            DocenteViewModel docenteView = new DocenteViewModel();

            if (Id.HasValue)
            {
                docenteView.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(Convert.ToInt32(Id));
            }
            else
            {
                docenteView.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(0);
            }

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
            var lstrueFalse = from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                              select new
                              {
                                  Id = (int)e,
                                  Descripcion = e.ToString()
                              };


          

            ViewBag.Departamento = new SelectList(_departamento.GetAll(), "Id", "Descripcion");
            ViewBag.Municipio = new SelectList(_municipio.GetAll(), "Id", "Descripcion");
            ViewBag.Etnia = new SelectList(_etnia.GetAll(), "Id", "Descripcion");
            ViewBag.Pais = new SelectList(_pais.GetAll(), "Id", "Descripcion");
            ViewBag.Sexo = new SelectList(enumData, "Id", "Descripcion");
            ViewBag.CivilStatus = new SelectList(lscivilstatus, "Id", "Descripcion");
            ViewBag.SINO = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.FormacionPedadogica = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.TipoContrato = new SelectList(_tipoContrato.GetAll(), "Id", "Descripcion");
            ViewBag.Cargo = new SelectList(_cargo.GetAll(), "Id", "Descripcion");
            ViewBag.ProfesionV = new SelectList(_profesion.GetAll(), "Id", "Descripcion");
            ViewBag.AreaV = new SelectList(_area.GetAll(), "Id", "Descripcion");
            ViewBag.RecintoV = new SelectList(_recinto.GetAll(), "Id", "Descripcion");
            ViewBag.NivelFormacionV = new SelectList(_nivelformacion.GetAll(), "Id", "Descripcion");
            ViewBag.TituloV = new SelectList(_titulo.GetAll(), "Id", "Descripcion");
            ViewBag.TipoDocumentoV = new SelectList(_tipodocumento.GetAll(), "Id", "Descripcion");
            //ViewBag.Asignaturas = docenteView.asignaturasView;

            return View(docenteView);

        }
        [HttpPost]
        public ActionResult AgregarDocente(DocenteViewModel model)
        {
            //DocenteViewModel docenteView = new DocenteViewModel();
          //if (model.docente.Id==0)NAddSubjectDocente
          //  }
                model.asignaturasView= _docenteRepositoy.LoadDocenteAsignatura(model.docente.Id);
           

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
            var lstrueFalse = from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                              select new
                              {
                                  Id = (int)e,
                                  Descripcion = e.ToString()
                              };



            ViewBag.Departamento = new SelectList(_departamento.GetAll(), "Id", "Descripcion");
            ViewBag.Municipio = new SelectList(_municipio.GetAll(), "Id", "Descripcion");
            ViewBag.Etnia = new SelectList(_etnia.GetAll(), "Id", "Descripcion");
            ViewBag.Pais = new SelectList(_pais.GetAll(), "Id", "Descripcion");
            ViewBag.Sexo = new SelectList(enumData, "Id", "Descripcion");
            ViewBag.CivilStatus = new SelectList(lscivilstatus, "Id", "Descripcion");
            ViewBag.SINO = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.FormacionPedadogica = new SelectList(lstrueFalse, "Id", "Descripcion");
            ViewBag.TipoContrato = new SelectList(_tipoContrato.GetAll(), "Id", "Descripcion");
            ViewBag.Cargo = new SelectList(_cargo.GetAll(), "Id", "Descripcion");
            ViewBag.ProfesionV = new SelectList(_profesion.GetAll(), "Id", "Descripcion");
            ViewBag.AreaV = new SelectList(_area.GetAll(), "Id", "Descripcion");
            ViewBag.RecintoV = new SelectList(_recinto.GetAll(), "Id", "Descripcion");
            ViewBag.NivelFormacionV = new SelectList(_nivelformacion.GetAll(), "Id", "Descripcion");
            ViewBag.TituloV = new SelectList(_titulo.GetAll(), "Id", "Descripcion");
            ViewBag.TipoDocumentoV = new SelectList(_tipodocumento.GetAll(), "Id", "Descripcion");
            //if (model.docente.Nombre == null)
            //{
            //    ModelState.AddModelError("", "Nombre no puede quedar vacio, Por favor registre el nombre del Docente ");
            //    return View(model);
            //}

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            int id = _docenteRepositoy.Add(model.docente);
            if (id > 0)
            {
                return RedirectToAction("Details", new { id = id });
            }
 

            return View(model);
        }

        public ActionResult _AddSubjectDocenteAction(int Id)
        {
            DocenteViewModel docenteView = new DocenteViewModel();
            docenteView.docente = _docenteRepositoy.GetById(Id);
           
            //docenteView.docente = dataDocente;
            docenteView.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(Id);


            //if (AsignaturaId.HasValue)
            //{
            //    var asig = _docenteRepositoy.GetSubjectDocente(dataDocente, Convert.ToInt32(AsignaturaId));
            //    if (asig.Count > 0)
            //    {
            //        //ModelState.AddModelError(string.Empty,"Ya existe la asignatura asociada");
            //        ModelState.AddModelError("docente", "Ya existe la asignatura asociada");

            //        return View("_AddSubjectDocente", docenteView);
            //    }
            //    else
            //    {
            //        _docenteRepositoy.AddSubject(dataDocente, Convert.ToInt32(AsignaturaId));

            //    _AddSubjectDocenteAction

            //}

            return View("_AddSubjectDocente", docenteView);
        }

        public bool AddSubjectDocente(int DocenteId, int AsignaturaId)
        {
            var dataDocente = _docenteRepositoy.GetById(DocenteId);


            var asig = _docenteRepositoy.GetSubjectDocente(dataDocente, Convert.ToInt32(AsignaturaId));
                if (asig.Count > 0)
                {
                    //ModelState.AddModelError(string.Empty,"Ya existe la asignatura asociada");
                    ModelState.AddModelError("docente", "Ya existe la asignatura asociada");

                    return false;
               

                 }
                else
            {
                _docenteRepositoy.AddSubject(dataDocente, Convert.ToInt32(AsignaturaId));
                return true;
            }
            
        }

        [HttpPost]
        public JsonResult DeleteSubjectDocente(DtoDocenteAsignatura docente)
        {
            if (ActionDeleteSubjectDocente(docente.DocenteId, docente.AsignaturaId))
            {
                bool success = true;
                return Json(new { success = success });
            }

            else
                return Json(String.Format("'success':'false','Error':'Ha habido un error al insertar el registro.'"));
        }
        public bool ActionDeleteSubjectDocente(int DocenteId, int AsignaturaId)
        {
    
                _docenteRepositoy.DeleteSubject(DocenteId, AsignaturaId);
                return true;
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

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
