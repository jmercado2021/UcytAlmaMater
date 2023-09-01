using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models;

namespace BlackSys.Controllers.SISCOMP
{
    public class AutorizadorController : Controller
    {
        private SISCOMPEntities db = new SISCOMPEntities();

        // GET: Autorizador
        public ActionResult Index()
        {
            var autorizador = db.Autorizador.Include(a => a.Estado).Include(a => a.Oficina);
            return View(autorizador.ToList());
        }

        // GET: Autorizador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autorizador autorizador = db.Autorizador.Find(id);
            if (autorizador == null)
            {
                return HttpNotFound();
            }
            return View(autorizador);
        }

        // GET: Autorizador/Create
        public ActionResult Create()
        {
            ViewBag.Estado_Id = new SelectList(db.Estado, "Estado_Id", "Descripcion");
            ViewBag.Oficina_Id = new SelectList(db.Oficina, "Oficina_Id", "Codigo");
            return View();
        }

        // POST: Autorizador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Autorizador_Id,Oficina_Id,Descripcion,Estado_Id")] Autorizador autorizador)
        {
            if (ModelState.IsValid)
            {
                db.Autorizador.Add(autorizador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Estado_Id = new SelectList(db.Estado, "Estado_Id", "Descripcion", autorizador.Estado_Id);
            ViewBag.Oficina_Id = new SelectList(db.Oficina, "Oficina_Id", "Codigo", autorizador.Oficina_Id);
            return View(autorizador);
        }

        // GET: Autorizador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autorizador autorizador = db.Autorizador.Find(id);
            if (autorizador == null)
            {
                return HttpNotFound();
            }
            ViewBag.Estado_Id = new SelectList(db.Estado, "Estado_Id", "Descripcion", autorizador.Estado_Id);
            ViewBag.Oficina_Id = new SelectList(db.Oficina, "Oficina_Id", "Codigo", autorizador.Oficina_Id);
            return View(autorizador);
        }

        // POST: Autorizador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Autorizador_Id,Oficina_Id,Descripcion,Estado_Id")] Autorizador autorizador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autorizador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Estado_Id = new SelectList(db.Estado, "Estado_Id", "Descripcion", autorizador.Estado_Id);
            ViewBag.Oficina_Id = new SelectList(db.Oficina, "Oficina_Id", "Codigo", autorizador.Oficina_Id);
            return View(autorizador);
        }

        // GET: Autorizador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autorizador autorizador = db.Autorizador.Find(id);
            if (autorizador == null)
            {
                return HttpNotFound();
            }
            return View(autorizador);
        }

        // POST: Autorizador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Autorizador autorizador = db.Autorizador.Find(id);
            db.Autorizador.Remove(autorizador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
