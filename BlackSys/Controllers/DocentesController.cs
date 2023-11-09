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
        private Repository.DocenteEstudios.IRepository _docEstudios;
        private Repository.AreaCapacitacion.IRepository _areacapacitacion;
        private Repository.DocenteAreaInvestigacion.IRepository _areaInvestigacion;
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
            _ejercDirec =   new Repository.EjercicioDirectivo.Repository(this.ModelState);
            _docEstudios = new Repository.DocenteEstudios.Repository(this.ModelState);
            _areacapacitacion = new Repository.AreaCapacitacion.Repository(this.ModelState);
            _areaInvestigacion = new Repository.DocenteAreaInvestigacion.Repository(this.ModelState);
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
                               Id = e.ToString(),
                               Descripcion = e.ToString()
                           };
            var lscivilstatus = from CivilStatus e in Enum.GetValues(typeof(CivilStatus))
                                select new
                                {
                                    Id = e.ToString(),
                                    Descripcion = e.ToString()
                                };
          


            var lsOriginBeca = from OriginBeca e in Enum.GetValues(typeof(OriginBeca))
                               select new
                               {
                                   Id = e.ToString(),
                                   Descripcion = e.ToString()
                               };
            var lsTypeBeca = from TypeBeca e in Enum.GetValues(typeof(TypeBeca))
                             select new
                             {
                                 Id = e.ToString(),
                                 Descripcion = e.ToString()
                             };
            var lstrueFalseEstudios = from SelectTrueFalseEstudies e in Enum.GetValues(typeof(SelectTrueFalseEstudies))
                                      select new
                                      {
                                          Id = e.ToString(),
                                          Descripcion = e.ToString()
                                      };


            var lszona = from Zone e in Enum.GetValues(typeof(Zone))
                         select new
                         {
                             Id = e.ToString(),
                             Descripcion = e.ToString()
                         };
            var lstrueFalse = from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                              select new
                              {
                                  Id = e.ToString(),
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
            ViewBag.DocenteEstudiosV = new SelectList(_docEstudios.GetAll(), "Id", "Descripcion");
            ViewBag.OriginBecaV = new SelectList(lsOriginBeca ,"Id", "Descripcion");
            ViewBag.TypeBecaV = new SelectList(lsTypeBeca, "Id", "Descripcion");
            ViewBag.AreaCapacitacionV = new SelectList(_areacapacitacion.GetAll(), "Id", "Descripcion");
            ViewBag.SINOAplica = new SelectList(lstrueFalseEstudios, "Id", "Descripcion");
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");
            ViewBag.AreaInvestigacionV = new SelectList(_areaInvestigacion.GetAll(), "Id", "Descripcion");
            
            return View(docenteView);
            //}
        }
        [HttpPost]
        public ActionResult Details(DocenteViewModel model)
        {
           

            var enumData = from Gender e in Enum.GetValues(typeof(Gender))
                           select new
                           {
                               Id = e.ToString(),
                               Descripcion = e.ToString()
                           };
            var lscivilstatus = from CivilStatus e in Enum.GetValues(typeof(CivilStatus))
                                select new
                                {
                                    Id = e.ToString(),
                                    Descripcion = e.ToString()
                                };


            var lsOriginBeca = from OriginBeca e in Enum.GetValues(typeof(OriginBeca))
                               select new
                               {
                                   Id = e.ToString(),
                                   Descripcion = e.ToString()
                               };
            var lsTypeBeca = from TypeBeca e in Enum.GetValues(typeof(TypeBeca))
                             select new
                             {
                                 Id = e.ToString(),
                                 Descripcion = e.ToString()
                             };
            var lstrueFalseEstudios = from SelectTrueFalseEstudies e in Enum.GetValues(typeof(SelectTrueFalseEstudies))
                                      select new
                                      {
                                          Id = e.ToString(),
                                          Descripcion = e.ToString()
                                      };


            var lszona = from Zone e in Enum.GetValues(typeof(Zone))
                         select new
                         {
                             Id = e.ToString(),
                             Descripcion = e.ToString()
                         };
            var lstrueFalse = from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                              select new
                              {
                                  Id = e.ToString(),
                                  Descripcion = e.ToString()
                              };

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
            ViewBag.TipoDocumentoV = new SelectList(_tipodocumento.GetAll(), "Id", "Descripcion", selectedValue: null);
            docenteView.asignaturasView = _docenteRepositoy.LoadDocenteAsignatura(model.docente.Id);
            ViewBag.CatDocenteV = new SelectList(_docenteCateg.GetAll(), "Id", "Descripcion");
            ViewBag.ZonaV = new SelectList(lszona, "Id", "Descripcion");
            ViewBag.EjercicioDirectivoV = new SelectList(_ejercDirec.GetAll(), "Id", "Descripcion");
            ViewBag.DocenteEstudiosV = new SelectList(_docEstudios.GetAll(), "Id", "Descripcion");
            ViewBag.OriginBecaV = new SelectList(lsOriginBeca, "Id", "Descripcion");
            ViewBag.TypeBecaV = new SelectList(lsTypeBeca, "Id", "Descripcion");
            ViewBag.AreaCapacitacionV = new SelectList(_areacapacitacion.GetAll(), "Id", "Descripcion");
            ViewBag.SINOAplica = new SelectList(lstrueFalseEstudios, "Id", "Descripcion");
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");
            ViewBag.AreaInvestigacionV = new SelectList(_areaInvestigacion.GetAll(), "Id", "Descripcion");

            if (model.docente.Nombre == null)
            {
                ModelState.AddModelError("", "Nombre no puede quedar vacio, Por favor registre el nombre del Docente ");
                return View(model);
            }

            //if (model.docente.Sexo == "SinAsignar")
            //{
            //    ModelState.AddModelError("", "Debe seleccionar el sexo ");
            //    return View(model);
            //}
            //if (model.docente.EtniaId == 0)
            //{
            //    ModelState.AddModelError("", "Debe seleccionar Etnia ");
            //    return View(model);
            //}
            //if (model.docente.TipoDocumentoId == 0)
            //{
            //    ModelState.AddModelError("", "Debe seleccionar el Tipo de documento ");
            //    return View(model);
            //}
            //if (model.docente.MunicipioId == 0)
            //{
            //    ModelState.AddModelError("", "Debe seleccionar el Municipio ");
            //    return View(model);
            //}
            //if (model.docente.PaisId == 0)
            //{
            //    ModelState.AddModelError("", "Debe seleccionar el Pais ");
            //    return View(model);
            //}
            //if (model.docente.DepartamentoId == 0)
            //{
            //    ModelState.AddModelError("", "Debe seleccionar el Departamento ");
            //    return View(model);
            //}
            //if (model.docente.CategoriaDocenteId == 0)
            //{
            //    ModelState.AddModelError("", "Debe seleccionar la categoria del docente");
            //    return View(model);
            //}
            //if (model.docente.MunicipioId == 0)
            //{
            //    ModelState.AddModelError("", "Debe seleccionar el municipio");
            //    return View(model);
            //}
            //if (model.docente.Zona == "SinAsignar")
            //{
            //    ModelState.AddModelError("", "Debe seleccionar la zona");
            //    return View(model);
            //}

            // Obtén todos los atributos públicos de la clase
            var properties = typeof(Models.Dal.Docente).GetProperties();



            foreach (var property in properties)
            {
                var value = property.GetValue(model.docente);

                // Verifica si el valor es el texto específico que deseas evitar
                if (value != null && value.ToString() == "0")
                {
                    // Agrega un error al modelo usando el nombre del atributo
                    ModelState.AddModelError(property.Name, $"Debe seleccionar  {property.Name}");
                    return View(model);
                }
               
            }



            // Itera sobre los atributos y verifica si alguno tiene el valor específico
            foreach (var property in properties)
            {
                var value = property.GetValue(model.docente);

                // Verifica si el valor es el texto específico que deseas evitar
                if (value != null && value.ToString() == "SinAsignar")
                {
                    // Agrega un error al modelo usando el nombre del atributo
                    ModelState.AddModelError(property.Name, $"No se permite el valor SinAsignar en {property.Name}");
                    return View(model);
                }
               
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
                               Id = e.ToString(),
                               Descripcion = e.ToString()
                           };
            var lscivilstatus = from CivilStatus e in Enum.GetValues(typeof(CivilStatus))
                                select new
                                {
                                    Id = e.ToString(),
                                    Descripcion = e.ToString()
                                };


            var lsOriginBeca = from OriginBeca e in Enum.GetValues(typeof(OriginBeca))
                               select new
                               {
                                   Id = e.ToString(),
                                   Descripcion = e.ToString()
                               };
            var lsTypeBeca = from TypeBeca e in Enum.GetValues(typeof(TypeBeca))
                             select new
                             {
                                 Id = e.ToString(),
                                 Descripcion = e.ToString()
                             };
            var lstrueFalseEstudios = from SelectTrueFalseEstudies e in Enum.GetValues(typeof(SelectTrueFalseEstudies))
                                      select new
                                      {
                                          Id = e.ToString(),
                                          Descripcion = e.ToString()
                                      };


            var lszona = from Zone e in Enum.GetValues(typeof(Zone))
                         select new
                         {
                             Id = e.ToString(),
                             Descripcion = e.ToString()
                         };
            var lstrueFalse = from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                              select new
                              {
                                  Id = e.ToString(),
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
            ViewBag.NivelFormacionV = new SelectList(_nivelformacion.GetAll(), "Id", "Descripcion");
            ViewBag.TituloV = new SelectList(_titulo.GetAll(), "Id", "Descripcion");
            ViewBag.TipoDocumentoV = new SelectList(_tipodocumento.GetAll(), "Id", "Descripcion", selectedValue: null);
            ViewBag.CatDocenteV = new SelectList(_docenteCateg.GetAll(), "Id", "Descripcion");
            ViewBag.ZonaV = new SelectList(lszona, "Id", "Descripcion");
            ViewBag.EjercicioDirectivoV = new SelectList(_ejercDirec.GetAll(), "Id", "Descripcion");
            ViewBag.DocenteEstudiosV = new SelectList(_docEstudios.GetAll(), "Id", "Descripcion");
            ViewBag.OriginBecaV = new SelectList(lsOriginBeca, "Id", "Descripcion");
            ViewBag.TypeBecaV = new SelectList(lsTypeBeca, "Id", "Descripcion");
            ViewBag.AreaCapacitacionV = new SelectList(_areacapacitacion.GetAll(), "Id", "Descripcion");
            ViewBag.SINOAplica = new SelectList(lstrueFalseEstudios, "Id", "Descripcion");
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");

            return View(docenteView);

        }
        [HttpPost]
        public ActionResult AgregarDocente(DocenteViewModel model)
        {


            var enumData = from Gender e in Enum.GetValues(typeof(Gender))
                           select new
                           {
                               Id = e.ToString(),
                               Descripcion = e.ToString()
                           };
            var lscivilstatus = from CivilStatus e in Enum.GetValues(typeof(CivilStatus))
                                select new
                                {
                                    Id = e.ToString(),
                                    Descripcion = e.ToString()
                                };


            var lsOriginBeca = from OriginBeca e in Enum.GetValues(typeof(OriginBeca))
                               select new
                               {
                                   Id = e.ToString(),
                                   Descripcion = e.ToString()
                               };
            var lsTypeBeca = from TypeBeca e in Enum.GetValues(typeof(TypeBeca))
                             select new
                             {
                                 Id = e.ToString(),
                                 Descripcion = e.ToString()
                             };
            var lstrueFalseEstudios = from SelectTrueFalseEstudies e in Enum.GetValues(typeof(SelectTrueFalseEstudies))
                                      select new
                                      {
                                          Id = e.ToString(),
                                          Descripcion = e.ToString()
                                      };


            var lszona = from Zone e in Enum.GetValues(typeof(Zone))
                         select new
                         {
                             Id = e.ToString(),
                             Descripcion = e.ToString()
                         };
            var lstrueFalse = from SelectTrueFalse e in Enum.GetValues(typeof(SelectTrueFalse))
                              select new
                              {
                                  Id = e.ToString(),
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
            ViewBag.NivelFormacionV = new SelectList(_nivelformacion.GetAll(), "Id", "Descripcion");
            ViewBag.TituloV = new SelectList(_titulo.GetAll(), "Id", "Descripcion");
            ViewBag.TipoDocumentoV = new SelectList(_tipodocumento.GetAll(), "Id", "Descripcion", selectedValue: null);
            ViewBag.CatDocenteV = new SelectList(_docenteCateg.GetAll(), "Id", "Descripcion");
            ViewBag.ZonaV = new SelectList(lszona, "Id", "Descripcion");
            ViewBag.EjercicioDirectivoV = new SelectList(_ejercDirec.GetAll(), "Id", "Descripcion");
            ViewBag.DocenteEstudiosV = new SelectList(_docEstudios.GetAll(), "Id", "Descripcion");
            ViewBag.OriginBecaV = new SelectList(lsOriginBeca, "Id", "Descripcion");
            ViewBag.TypeBecaV = new SelectList(lsTypeBeca, "Id", "Descripcion");
            ViewBag.AreaCapacitacionV = new SelectList(_areacapacitacion.GetAll(), "Id", "Descripcion");
            ViewBag.SINOAplica = new SelectList(lstrueFalseEstudios, "Id", "Descripcion");
            ViewBag.Asignaturas = new SelectList(_Asignatura.GetAll(), "Id", "Nombre");
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
