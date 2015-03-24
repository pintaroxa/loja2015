using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
         
        protected void Application_Start()
        {
            //////////////////////////////////////////////////////////////////
            // commando para não estartar o banco automaticamente
            Database.SetInitializer<EfdbContex>(null);
            //////////////////////////////////////////////////////////////////


            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
