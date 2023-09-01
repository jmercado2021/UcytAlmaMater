using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models;
using Microsoft.AspNet.Identity;

namespace BlackSys.Controllers.Articulos
{
    public class TblCasasController : Controller
    {
        //private COMERCIALEntities db = new COMERCIALEntities();

        // GET: TblCasas
        public ActionResult Index()
        {
            //return View(db.TblCasa.ToList());
            return View();
        }

        // GET: TblCasas/Details/5
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //TblCasa tblCasa = db.TblCasa.Find(id);
            //if (tblCasa == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(tblCasa);
            return View();
        }

        // GET: TblCasas/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: TblCasas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string Nombre)
        {
            return View();
            //var user = User.Identity.GetUserName();
            //db.W_InsertarCasa(Nombre, user);
            //var nombre = Nombre;
            //return RedirectToAction("Index");



        }

        // GET: TblCasas/Edit/5
        public ActionResult Edit(int? id)
        {
            return View();
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //TblCasa tblCasa = db.TblCasa.Find(id);
            //if (tblCasa == null)
            //{
            //    return HttpNotFound();
            //}
            //return PartialView(tblCasa);
        }

        // POST: TblCasas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? Id, string Nombre, string Activo)
        {
            //using (var ctx = new COMERCIALEntities())
            //{
            //    using (var ctxTrans = ctx.Database.BeginTransaction())
            //    {
            //        try
            //        {

            //            string ActivoP = "";
            //            if (ModelState.IsValid)
            //            {
            //                if (Activo == "on")
            //                {
            //                    ActivoP = "SI";
            //                }
            //                else
            //                {
            //                    ActivoP = "NO";
            //                }
            //            }
            //            var user = User.Identity.GetUserName();

            //            db.W_ModificaCasa(Id, Nombre, user, ActivoP);
            //            ctxTrans.Commit(); // Aprobado
            //        }
            //        catch (Exception)
            //        {
            //            ctxTrans.Rollback(); // Desaprobado
            //        }
            //        return RedirectToAction("Index");
            //    }
            //}
            return View();
        }

        // GET: TblCasas/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //TblCasa tblCasa = db.TblCasa.Find(id);
            //if (tblCasa == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(tblCasa);
            return View();
        }


    }
}
