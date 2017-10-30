using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json.Serialization;

namespace WebAPI_Basics
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      // Get Global Configuration
      //HttpConfiguration config =
      //    GlobalConfiguration.Configuration;

      //var jsonFormatter =
      //  config.Formatters.OfType
      //     <JsonMediaTypeFormatter>()
      //       .FirstOrDefault();

      //jsonFormatter.SerializerSettings.
      //   ContractResolver = new
      //     CamelCasePropertyNamesContractResolver();

    }
  }
}
