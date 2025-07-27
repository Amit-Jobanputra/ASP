using System.Web;
using System.Web.Mvc;

namespace Assignment_Three_AJ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
