using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace AngularJSAuthentication.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //No need to fire it up because OWIN startup will call our startup class
          //  GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
