using TiendaVirtual.Filtros;
using System.Web;
using System.Web.Mvc;

namespace TiendaVirtual
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LoginActionAttribute());
        }
    }
}
