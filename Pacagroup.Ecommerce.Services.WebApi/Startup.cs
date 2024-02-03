using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Pacagroup.Ecommerce.Application.Interface;
using Pacagroup.Ecommerce.Application.Main;
using Pacagroup.Ecommerce.Domain.Core;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infraestructura.Data;
using Pacagroup.Ecommerce.Infraestructura.Interface;
using Pacagroup.Ecommerce.Infraestructura.Repository;
using Pacagroup.Ecommerce.Services.WebApi.Helpers;
using Pacagroup.Ecommerce.Transversal.Common;
using Pacagroup.Ecommerce.Transversal.Logging;
using Pacagroup.Ecommerce.Transversal.Mapper;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Services.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public string myPolicy = "PolicyApiEcommerce";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));

            services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(Configuration["Config:OriginCors"])
                                                                                       .AllowAnyHeader()
                                                                                       .AllowAnyMethod()));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => { options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver(); });

            var appSettingsSection = Configuration.GetSection("Config");

            services.Configure<AppSettings>(appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSettings>();

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddScoped<IUsersApplication, UsersApplication>();
            services.AddScoped<ICustomersDomain, CustomersDomain>();
            services.AddScoped<IUsersDomain, UsersDomain>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var Issuer = appSettings.Issuer;
            var Audience = appSettings.Audience;

            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
                {
                    x.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = context =>
                        {
                            var userId = int.Parse(context.Principal.Identity.Name);
                            return Task.CompletedTask;
                        },

                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.Headers.Add("Token-Expired", "true");
                            }
                            return Task.CompletedTask;
                        }
                    };
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = false;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidIssuer = Issuer,
                        ValidateAudience = true,
                        ValidAudience = Audience,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Pacagroup technology service API Market",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "none",
                    Contact = new Contact
                    {
                        Name = "Andres Camilo Ferreira Rodriguez",
                        Email = "ac.ferreira.r@gmail.com",
                        Url = "https://github.com/AndresFerreiraR/BusinessArchitecture/blob/develop/README.md"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "http://google.com.co"
                    }
                });
                var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlfile);
                c.IncludeXmlComments(xmlpath);

                c.AddSecurityDefinition("Authorization", new ApiKeyScheme
                {
                    Description = "Authorization by API key",
                    In = "header",
                    Type = "apiKey",
                    Name = "Authorization"
                });

                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    { "Authorization", new string[0]}
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API Ecommerce V1");
            });

            app.UseCors(myPolicy);
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
