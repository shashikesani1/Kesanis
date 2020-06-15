using System.Web;
using System.Web.Mvc;

namespace Kesanis.AspNet.Mvc.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
