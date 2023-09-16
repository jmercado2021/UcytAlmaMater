using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackSys.Controllers
{
    public class AsignaturaController : Controller
    {
        // GET: Asignatura
        public ActionResult Index()
        {
            return View();
        }

        // GET: Asignatura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Asignatura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asignatura/Create
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

        // GET: Asignatura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Asignatura/Edit/5
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

        // GET: Asignatura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Asignatura/Delete/5
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
