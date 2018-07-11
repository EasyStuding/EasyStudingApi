using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
using EasyStudingModels.Models;

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
            
            BuildAppSettingsProvider();

            RegisterDependencyInjection(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseCors("MyPolicy");

            app.UseMvc();
        }

        private void RegisterDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IRepository<Attachment>, UniversalRepository<Attachment>>();
            services.AddScoped<IRepository<City>, UniversalRepository<City>>();
            services.AddScoped<IRepository<Country>, UniversalRepository<Country>>();
            services.AddScoped<IRepository<Order>, UniversalRepository<Order>>();
            services.AddScoped<IRepository<OrderSkill>, UniversalRepository<OrderSkill>>();
            services.AddScoped<IRepository<Region>, UniversalRepository<Region>>();
            services.AddScoped<IRepository<Review>, UniversalRepository<Review>>();
            services.AddScoped<IRepository<Skill>, UniversalRepository<Skill>>();
            services.AddScoped<IRepository<User>, UniversalRepository<User>>();
            services.AddScoped<IRepository<UserSkill>, UniversalRepository<UserSkill>>();
            services.AddScoped<IRepository<UserPassword>, UniversalRepository<UserPassword>>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<EasyStudingContext>(options => 
                options.UseNpgsql(AppSettings.DBConnectionString));

            services.AddScoped<ISessionController, SessionController>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<ISessionRepository, SessionRepository>();

            services.AddScoped<IModeratorController, ModeratorController>();
            services.AddScoped<IModeratorService, ModeratorService>();
            services.AddScoped<IModeratorRepository, ModeratorRepository>();

            services.AddScoped<IExecutorController, ExecutorController>();
            services.AddScoped<IExecutorService, ExecutorService>();
            services.AddScoped<IExecutorRepository, ExecutorRepository>();

            services.AddScoped<IUserController, UserController>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ILocationController, LocationController>();
            services.AddScoped<ILocationService, LocationService>();
        }

        private void BuildAppSettingsProvider()
        {
            AppSettings.DBConnectionString = 
                Defines.GetDecodedString(Configuration["AppSettings:DBConnectionString"]);

            AppSettings.GMailLogin = 
                Defines.GetDecodedString(Configuration["AppSettings:GMailLogin"]);
            AppSettings.GMailPassword = 
                Defines.GetDecodedString(Configuration["AppSettings:GMailPassword"]);

            AppSettings.TwilioFromNumber = 
                Defines.GetDecodedString(Configuration["AppSettings:TwilioFromNumber"]);
            AppSettings.TwilioAccountSID =
                Defines.GetDecodedString(Configuration["AppSettings:TwilioAccountSID"]);
            AppSettings.TwilioAuthToken = 
                Defines.GetDecodedString(Configuration["AppSettings:TwilioAuthToken"]);
        }
    }
}
