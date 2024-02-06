
namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Swagger
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;
    using System.IO;
    using System.Reflection;
    using System;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using System.Collections.Generic;

    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
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
                });
                var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlfile);
                c.IncludeXmlComments(xmlpath);

                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "Enter JWT Bearer token **_only_**",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Id = JwtBearerDefaults.AuthenticationScheme,
                        Type = ReferenceType.SecurityScheme
                    }
                };

                c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {securityScheme, new List<string>(){ } }
                });
            });

            return services;
        }
    }
}
