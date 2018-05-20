using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using ApiKey.MessageHandle;

namespace ApiKey
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //Add config for API KEY handler
            GlobalConfiguration.Configuration.MessageHandlers.Add(new ApiKeyMessageHandler());
          
            RouteConfig.RegisterRoutes(RouteTable.Routes);

           
        }
    }
}