using Microsoft.OpenApi.Models;
using Tweetbook.Options;

namespace Tweetbook.Installers;

public class MvcInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(x => { x.SwaggerDoc("v1", new OpenApiInfo { Title = "Tweetbook API", Version = "v1" }); });
        services.AddControllersWithViews();
        var swaggerOptions = new SwaggerOptions();
        configuration.GetSection(nameof(swaggerOptions)).Bind(swaggerOptions);

    }
}
