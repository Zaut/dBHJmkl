using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

//namespace TechService.App_Start
namespace TechService
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "", "~/Pages/Main.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Main.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Main.aspx");
            routes.MapPageRoute(null, "list/{category}/{page}", "~/Pages/Main.aspx");

            //routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");

            //routes.MapPageRoute("checkout", "checkout", "~/Pages/Checkout.aspx");
        }
    }
}