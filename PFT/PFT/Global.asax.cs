using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PFT.DAL;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity;

namespace PFT
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var lfContext = new LFContext();
            Database.SetInitializer(new LFInitializer());
           // lfContext.Database.Initialize(true);
            DbInterception.Add(new LFInterceptorTransientErrors());
            DbInterception.Add(new LFInterceptorLogging());
        }
    }
}
