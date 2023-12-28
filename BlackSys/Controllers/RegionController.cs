using BlackSys.Models.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackSys.Controllers
{
    public class RegionController : Controller
    {
        private Repository.Region.IRepository _region;
        private UcytAlmaMaterEntities context;
        public RegionController()
        {
            _region = new Repository.Region.Repository(this.ModelState);
            this.context = new UcytAlmaMaterEntities(); // Inicializa tu contexto aquí
            this.context.Configuration.ProxyCreationEnabled = false; //
        }
        // GET: Region
        public JsonResult GetMunicioByDepId(int Id)
        {

            //using (models context = new models())
            //{
            //    context.Configuration.ProxyCreationEnabled = false; // included the following code
            //    var CustomerList = context.Customers.ToList();
            //    var jsondata = new JavaScriptSerializer().Serialize(CustomerList);
            //    string path = Server.MapPath("~/Json/");
            //    System.IO.File.WriteAllText(path + "customer.json", jsondata);
            //    return Json(CustomerList, JsonRequestBehavior.AllowGet);
            //}
       
        //var da = _region.GetAllByDepId(Id);
            return Json(_region.GetAllByDepId(Id),JsonRequestBehavior.AllowGet);
        }
       
    }
}
