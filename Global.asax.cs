using MvcMusicStore.Data;
using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //intitalize the database with some data pulled from the model(in this case the MusicStoreDbInitalizer Model)
            Database.SetInitializer( new MusicStoreDbInititalizer());

            //empty the database data(becasue we are testing the app we want to initalize and seed some data)
            // for now this code will be commented out
            //Database.SetInitializer(new DropCreateDatabaseAlways<MvcMusicStoreDB>());
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
