
namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Swagger
{
    using Asp.Versioning.ApiExplorer;
    using Microsoft.Extensions.Options;
    using Microsoft.OpenApi.Models;
    using Swashbuckle.AspNetCore.SwaggerGen;


    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IApiVersionDescriptionProvider provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => this.provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
        }

        static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Version = description.ApiVersion.ToString(),
                Title = "Pacagroup technology service API Market",
                Description = "A simple example ASP.NET Core Web API",
                TermsOfService = new Uri("https://github.com/AndresFerreiraR/BusinessArchitecture/blob/develop/README.md"),
                Contact = new OpenApiContact
                {
                    Name = "Andres Camilo Ferreira Rodriguez",
                    Email = "ac.ferreira.r@gmail.com",
                    Url = new Uri("https://github.com/AndresFerreiraR/BusinessArchitecture/blob/develop/README.md")
                },
                License = new OpenApiLicense
                {
                    Name = "Use under LICX",
                    Url = new Uri("http://google.com.co")
                }
            };

            if(description.IsDeprecated)
            {
                info.Description += "Esta version de la API quedo obsoleta";
            }

            return info;
        }
    }
}
