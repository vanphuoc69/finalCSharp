using System.Web.Mvc;

namespace TestUngDung.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Create_default",
                "admin/{controller}/{action}/{user}",
                new { controller = "User", action = "Create", user = UrlParameter.Optional }
            );

            context.MapRoute(
                "Product_Delete_default",
                "admin/{controller}/{action}/{id}",
                new { controller = "Product", action = "Delete", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Product_Index_default",
                "admin/{controller}",
                new { controller = "Product", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "User_Index_default",
                "admin/{controller}",
                new { controller = "User", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}