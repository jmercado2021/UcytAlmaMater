using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models;
using BlackSys.Controllers.SISCOMP;
using System.Data.SqlClient;

namespace BlackSys.Controllers.SISCOMP
{
    public class OficinaController : Controller
    {
        private SISCOMPEntities db = new SISCOMPEntities();

        // GET: Oficina
        public ActionResult Index()
        {
            var oficina = db.Oficina.Include(o => o.Estado);
            return View(oficina.ToList());
        }

        // GET: Oficina/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oficina oficina = db.Oficina.Find(id);
            if (oficina == null)
            {
                return HttpNotFound();
            }
            return View(oficina);
        }

        // GET: Oficina/Create
        public ActionResult Create()
        {
            using (SISCOMPEntities db = new SISCOMPEntities())
            {
                var codigo = Metodos.GetUltimoId("Oficina", "Oficina_Id");
            }
       

            ViewBag.Estado_Id = new SelectList(db.Estado, "Estado_Id", "Descripcion");
            return View();
        }

        // POST: Oficina/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Oficina_Id,Codigo,Descripcion,RazonSocial,Direccion,Ruc,Telefono,Representante,ImagenLogo,ConsecutivoOrdenCompra,Estado_Id")] Oficina oficina)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Oficina.Add(oficina);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

        SqlConnection conn = null;
        SqlDataReader rdr = null;
        //db = new SISCOMPEntities();

        try
        {
            conn = new SqlConnection(db.Database.Connection.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Usp_CrearOficina", conn);
            cmd.CommandTimeout = 0;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", oficina.Descripcion);
                cmd.Parameters.AddWithValue("@RazonSocial", oficina.RazonSocial);
                cmd.Parameters.AddWithValue("@Direccion", oficina.Direccion);
            cmd.Parameters.AddWithValue("@Ruc", oficina.Ruc);
            cmd.Parameters.AddWithValue("@Telefono", oficina.Telefono);
            cmd.Parameters.AddWithValue("@Representante", oficina.Representante);
            cmd.Parameters.AddWithValue("@ImagenLogo", oficina.ImagenLogo);

            cmd.ExecuteNonQuery(); // MISSING
            return View(oficina);

            }
        catch (SqlException e)
        {
                //MessageBox.Show(e.Message + ' ' + e.InnerException);
                //return false;
                return RedirectToAction("Index");
            }
        finally
        {
            if (conn != null)
            {
                conn.Close();
            }
            if (rdr != null)
            {
                rdr.Close();
            }
                
       }
  }
        // GET: Oficina/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oficina oficina = db.Oficina.Find(id);
            if (oficina == null)
            {
                return HttpNotFound();
            }
            ViewBag.Estado_Id = new SelectList(db.Estado, "Estado_Id", "Descripcion", oficina.Estado_Id);
            return View(oficina);
        }

        // POST: Oficina/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Oficina_Id,Codigo,Descripcion,RazonSocial,Direccion,Ruc,Telefono,Representante,ImagenLogo,ConsecutivoOrdenCompra,Estado_Id")] Oficina oficina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oficina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Estado_Id = new SelectList(db.Estado, "Estado_Id", "Descripcion", oficina.Estado_Id);
            return View(oficina);
        }

        // GET: Oficina/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oficina oficina = db.Oficina.Find(id);
            if (oficina == null)
            {
                return HttpNotFound();
            }
            return View(oficina);
        }

        // POST: Oficina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Oficina oficina = db.Oficina.Find(id);
            db.Oficina.Remove(oficina);
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
