using BlackSys.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace BlackSys.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private BlackSysEntities db = new BlackSysEntities();
        public ActionResult Index()
        {
            
        }

        [Authorize]
        public ActionResult Contact()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult LoadMenu()
        {
            string user = User.Identity.GetUserId();
  
            var lista = db.MenuTemp.SqlQuery(
      "SELECT *FROM dbo.MenuTemp where UserId like '%" + user + "%'").ToList();
            return View(lista);
        }


    }
}