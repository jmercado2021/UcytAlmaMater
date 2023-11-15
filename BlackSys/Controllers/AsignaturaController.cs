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

      
    }
}
