using System.Web;
using System.Web.Mvc;

namespace Assingment_one_Qfour_AmitJ
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
