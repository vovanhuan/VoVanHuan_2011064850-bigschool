using System.Web;
using System.Web.Mvc;

namespace VoVanHuan_2011064850_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
