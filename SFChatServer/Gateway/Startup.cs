using System.Web.Http;
using Owin;
using Swashbuckle.Application;

namespace Gateway
{
    public static class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public static void ConfigureApp(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{action}",
                new {}
                );

            config.EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API")).EnableSwaggerUi();

            appBuilder.UseWebApi(config);
        }
    }
}