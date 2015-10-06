using System.Web;
using System.Web.Mvc;

namespace AdtvDemo.WUS.WebAPI.Logistics
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
