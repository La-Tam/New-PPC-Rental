using System.Web;
using System.Web.Mvc;

namespace K21T2_TheBOSS_Team4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
