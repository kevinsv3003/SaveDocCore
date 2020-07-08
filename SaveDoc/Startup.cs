using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaveDoc.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using AutoMapper;
using Dominio.Mapa;
using Microsoft.AspNetCore.Http.Features;
using SaveDoc.Models;
using InfraEstructura.IoC;
using InfraEstructura.AccesoDatos;
using Entidades.Entidades;

namespace SaveDoc
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            #region//CONFIGURACIÓN DE CONEXION A LA BASE DE DATOS
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MiProyectoCore")));

            services.AddDbContext<DocumentoContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("MiProyectoCore")));
            #endregion

            #region//CONFIGURACION DE USO DE IDENTITY - AUTENTICACION DE USUARIO 
            services.AddIdentity<UsuarioApp, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders(); 
            #endregion

            #region//CONFIGURACION DE LAS RUTAS ACCESO POR DEFECTO
            services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme,
            opt =>
            {
                opt.LoginPath = "/Account/Index";
                opt.AccessDeniedPath = "/Account/AccesoDenegado";
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(30);

            });
            #endregion

            #region//CONFIGURACION DE LAS PROPIEDADES DE IDENTITY
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 1;

                // Default SignIn settings.
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 4;
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = false;

            });
            
            //Declaracion de Polices
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RoleAdmin",
                    policy => policy.RequireRole("ADMIN"));
            });

            #endregion

            #region//CONFIGURACION DEL AUTOMAPPER
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddAutoMapper();
            #endregion

            #region//CODIGO PARA CAMBIAR EL TAMAÑO DEL BUFFER DE LOS ARCHIVOS
            services.Configure<FormOptions>(x =>
            {
                x.MultipartBodyLengthLimit = 209715200;
            });
            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            ServicioIoC.Service(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
