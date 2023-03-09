using System.Web;
using System.Web.Mvc;

namespace BigSchool_2011060950_PhanNgocSon_20DTHB3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
