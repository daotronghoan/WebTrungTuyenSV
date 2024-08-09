using System.Web;
using System.Web.Mvc;

namespace C1D1_DaoTrongHoan_2021606290
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
