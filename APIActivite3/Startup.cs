using APIActivite3.Filters;
using APIActivite3.Utils;
using BLL;
using Domaine;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocFx;

namespace APIActivite3
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
            services.AddTransient<ICurrentUserUtils, CurrentUserUtils>(); 
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.IgnoreNullValues = true; // On ne s�rialise pas les propri�t�s � null
                options.JsonSerializerOptions.PropertyNamingPolicy = null; // Pas de CamelCase sur les noms des propri�t�s
                
            });


            // Singleton => Toute la dur�e de vie du server
            // Scoped => Toute la dur�e de vie de la requ�te d'un client
            // Transient => A chaque fois que je demande le service => nouvelle instance

            //BLLExtensions.AddBll(services);
            /* Can replace with */
            services.AddBLLExtension();
            services.AddDomain();

            services.AddControllers(options =>
            {
                options.Filters.Add(new ApiExceptionFilterAttribute());
            });
            services.AddFluentValidation(options => options.LocalizationEnabled = false);



            //Add Authentification JWT
            //JWT Authentication
            services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = false, // Voulez vous valider l'issuer
                        ValidateAudience = false,
                        ValidAudience = Configuration["JwtIssuer"],
                        ValidIssuer = Configuration["JwtIssuer"],

                        ValidateIssuerSigningKey = true, // Validation Signature
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtKey"])),
                        //Retourne la diff�rence de temps maximale autoris�e entre le client et les param�tres de l'horloge du serveur.
                        ClockSkew = TimeSpan.Zero // remove delay of token when expire
                    };
                });


            // Register the Swagger services
            services.AddSwaggerDocument();

        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // For DocFx Documentation 

            app.UseDocFxUI((settings) =>
            {
                settings.Path = "/doc";
            });

            // Register the Swagger generator and the Swagger UI middlewares

            //G�n�ration du JSON
            app.UseOpenApi();

            //Interface utilisateur de la documentation
            app.UseSwaggerUi3();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

