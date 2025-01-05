using System.Web;
using System.Web.Mvc;

namespace Nguyenvoan_2122110249
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
