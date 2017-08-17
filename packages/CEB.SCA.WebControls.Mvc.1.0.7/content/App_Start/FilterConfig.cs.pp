using System.Web;
using System.Web.Mvc;
using CEB.SCA.WebControls.Mvc.Filters;

namespace $rootnamespace$
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SCAAuthorizeAttribute());
        }
    }
}