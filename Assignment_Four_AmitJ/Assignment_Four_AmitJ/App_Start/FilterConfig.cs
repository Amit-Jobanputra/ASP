using System.Web;
using System.Web.Mvc;

namespace Assignment_Four_AmitJ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
