using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using EasyStudingModels;
using EasyStudingInterfaces.Controllers;
using EasyStudingInterfaces.Services;
using EasyStudingInterfaces.Repositories;
using EasyStudingApi.Controllers;
using EasyStudingServices.Services;
using EasyStudingRepositories.Repositories;
using EasyStudingRepositories.DbContext;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using EasyStudingApi.Filters;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace EasyStudingApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .AllowCredentials();
            }));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        // Specifies whether the publisher will validate when validating the token.
                        ValidateIssuer = false,
                        // Will the token consumer be validated.
                        ValidateAudience = false,
                        // Will the lifetime be validated.
                        ValidateLifetime = true,
                        // Set the security key.
                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                        // Validate the security key.
                        ValidateIssuerSigningKey = true
                    };
                });

            services.AddMvc(options =>
                options.Filters.Add(new ControllerExceptionFilterAttribute()));

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("MyPolicy"));
            });

            RegisterDependencyInjection(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseCors("MyPolicy");

            app.UseMvc();
        }

        private void RegisterDependencyInjection(IServiceCollection services)
        {
            services.AddSingleton<IFileProvider>(
                new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<EasyStudingContext>(options => options.UseNpgsql(EasyStudingContext.CONNECTION_STRING));
            services.AddScoped<ISessionController, SessionController>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<ISessionRepository, SessionRepository>();
        }
    }
}
