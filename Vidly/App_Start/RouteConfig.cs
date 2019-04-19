using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); //to activate attribute based routing

            //// New cutom route created for study, We should have the order of the route from morespecific to more generic
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}", //we can craete a user defined url pattern unlike controller/action etc done in default route
            //    new {Controller= "Movies", Action ="ByReleaseDate"},
            //    new {year = @"\d{4}", month =@"\d{2}"} // here we added this new line of code to explain that we can control the pattern of parameters.
            //    //new {year = @"2018|2019"} // similarly we can restrit theparameter to some specific values
            //    );
            // /////////////////////////////////////////////////////////////////////////
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
