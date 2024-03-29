﻿using Newtonsoft.Json;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BlackSys
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };
        }
        //void Application_Error(object sender, EventArgs e)
        //{
        //    Exception objErr = Server.GetLastError().GetBaseException();
        //    string err = "Error Caught in Application_Error event\n" +
        //            "Error in: " + Request.Url.ToString() +
        //            "\nError Message:" + objErr.Message.ToString() +
        //            "\nStack Trace:" + objErr.StackTrace.ToString();
        //    System.Diagnostics.EventLog.WriteEntry("Sample_WebApp", err, System.Diagnostics.EventLogEntryType.Error);
        //    Server.ClearError();
        //    Response.Redirect(string.Format("{0}?exceptionMessage={1}", System.Web.VirtualPathUtility.ToAbsolute("~/ErrorPage.aspx"), objErr.Message));
        //}
    }
}
