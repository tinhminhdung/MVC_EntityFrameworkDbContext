using System.Web;
using System.Web.Mvc;

namespace MVC_EntityFrameworkDbContext
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
