using Microsoft.AspNetCore.Builder;


namespace Rotativa.AspNetCore
{
    public static class MvcServiceCollectionExtensions
    {
        public static IApplicationBuilder UseRotativa(this IApplicationBuilder app, string webRoot)
        {
   
            RotativaConfiguration.Setup(webRoot);

            return app;

        }

    }

}
