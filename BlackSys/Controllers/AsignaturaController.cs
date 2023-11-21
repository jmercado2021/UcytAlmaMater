using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models.Dal;
using static BlackSys.Models.Enum.ClEnum;

namespace BlackSys.Controllers
{
    public class AsignaturaController : Controller
    {
        // GET: Asignatura
        private Repository.Asignatura.IRepository _subject;

        public AsignaturaController()
            {
                    _subject = new Repository.Asignatura.Repository(this.ModelState);

            }

         public ActionResult Index()
        {

            return View(_subject.GetAll());
        }
        public ActionResult ParcialListado(string Nombre)
        {
            return PartialView(_subject.FindByName(Nombre));
        }
        public ActionResult Details (int Id)
        {
            var JustTrueFalse = from Activo e in Enum.GetValues(typeof(Activo))
                                select new
                                {
                                    Id = e.ToString(),
                                    Descripcion = e.ToString()
                                };
            ViewBag.SINO = new SelectList(JustTrueFalse, "Id", "Descripcion");
            Models.Dal.Asignatura data = new Models.Dal.Asignatura();
            data = _subject.GetById(Id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Details(Asignatura model)
        {

            try
            {
                var JustTrueFalse = from Activo e in Enum.GetValues(typeof(Activo))
                                    select new
                                    {
                                        Id = e.ToString(),
                                        Descripcion = e.ToString()
                                    };
                ViewBag.SINO = new SelectList(JustTrueFalse, "Id", "Descripcion");
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                _subject.Update(model);
                TempData["Mensaje"] = "Actualizacion exitosa";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Mensaje"] = "Ocurrio un Error al actualizar el registro";
                return View(model);
            }

        }
        public ActionResult Add(int Id)
        {
            var JustTrueFalse = from Activo e in Enum.GetValues(typeof(Activo))
                                select new
                                {
                                    Id = e.ToString(),
                                    Descripcion = e.ToString()
                                };
            ViewBag.SINO = new SelectList(JustTrueFalse, "Id", "Descripcion");
            Models.Dal.Asignatura data = new Models.Dal.Asignatura();
            return View(data);
        }
        [HttpPost]
        public ActionResult Add(Models.Dal.Asignatura model)
        {
            try
            {
                var JustTrueFalse = from Activo e in Enum.GetValues(typeof(Activo))
                                    select new
                                    {
                                        Id = e.ToString(),
                                        Descripcion = e.ToString()
                                    };
                ViewBag.SINO = new SelectList(JustTrueFalse, "Id", "Descripcion");
                _subject.Add(model);
                var m = _subject.GetById(model.Id);
                TempData["Mensaje"] = "Registro exitoso";
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                TempData["Mensaje"] = "Ocurrio un Error al actualizar el registro";
                return View(model);
            }
     
        }
    }
}
