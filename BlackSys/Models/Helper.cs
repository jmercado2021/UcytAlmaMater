using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackSys.Models
{
    public partial class Helper
    {
        public string GetUserName()
        {
            var user = HttpContext.Current.User.Identity.Name;
            return user;
        }
    }
}