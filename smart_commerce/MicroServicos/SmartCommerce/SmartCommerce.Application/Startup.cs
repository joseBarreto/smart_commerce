using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using SmartCommerce.Domain.Entities;

using SmartCommerce.Domain.Interfaces;
using SmartCommerce.Infra.Data.Context;
using SmartCommerce.Infra.Data.Repository;
using SmartCommerce.Service.Services;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;
using System;

namespace SmartCommerce.Application
{
#pragma warning disable CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
    
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<SmartCommerceContext>(options => options.UseOracle(Configuration.GetConnectionString("SmartCommerceContext")));

            #region repository
            services.AddScoped<IBaseRepository<Local>, BaseRepository<Local>>();
            services.AddScoped<IBaseRepository<Perfil>, BaseRepository<Perfil>>();
            services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            services.AddScoped<IBaseRepository<Segmento>, BaseRepository<Segmento>>();
            services.AddScoped<IBaseRepository<Segmento>, BaseRepository<Segmento>>();
            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseRepository<Votacao>, BaseRepository<Votacao>>();
            #endregion

            #region service
            services.AddScoped<IBaseService<Local>, BaseService<Local>>();
            services.AddScoped<IBaseService<Perfil>, BaseService<Perfil>>();
            services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            services.AddScoped<IBaseService<Segmento>, BaseService<Segmento>>();
            services.AddScoped<IBaseService<Segmento>, BaseService<Segmento>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddScoped<IBaseService<Votacao>, BaseService<Votacao>>();
            #endregion

            #region swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "SmartCommerce Services",
                    Description = "API para do SmartCommerce"
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            #endregion
            
            //services.AddSingleton(new MapperConfiguration(config =>
            //{
            //    config.CreateMap<CreateUserModel, User>();
            //    config.CreateMap<UpdateUserModel, User>();
            //    config.CreateMap<User, UserModel>();
            //}).CreateMapper());
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cyrela Services V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

#pragma warning restore CS1591 // O comentário XML ausente não foi encontrado para o tipo ou membro visível publicamente
}
