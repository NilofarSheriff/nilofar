using System.Web;
using System.Web.Mvc;

namespace _06OctoberAssignement_Adomvc_modelBinding
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
