using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BigSchool_2011060950_PhanNgocSon_20DTHB3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
