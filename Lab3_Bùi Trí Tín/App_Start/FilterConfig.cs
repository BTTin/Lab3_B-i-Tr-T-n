using System.Web;
using System.Web.Mvc;

namespace Lab3_Bùi_Trí_Tín
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
