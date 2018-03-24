using System.Web;
using System.Web.Mvc;

namespace RealEstate.Extentions
{
    public static class UrlExtentions
    {
        public static string IsLinkActive(this UrlHelper url, string controller)
        {
            var route = HttpContext.Current.Request.RequestContext.RouteData.Values["controller"].ToString();
            if (controller == route)
            {
                return "active";
            }
            return string.Empty;
        }
    }
}