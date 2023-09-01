using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackSys.Controllers
{
    public class DocentesController : Controller
    {
        private BlackSys.Repository.Docentes.IRepository _docenteRepositoy;
        public DocentesController()
        {
            _docenteRepositoy = new BlackSys.Repository.Docentes.Repository(this.ModelState);
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

        // GET: Docentes/Create
        public ActionResult Create()
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
        public ActionResult Edit(int id)
        {
            return View();
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
