using CinemaDomain;
using CinemaRepository.Base;
using CinemaRepository.Context;
using CinemaService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection Services;
        public static IServiceProvider ServiceProvider;
        
        public static void Configure()
        {
            Services = new ServiceCollection();

            Services.AddScoped<IBaseRepository<Genero>, BaseRepository < Genero >> ();
            Services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();

            var strCon = File.ReadAllText("Config/ConfigDB.txt");
            
            Services.AddDbContext<MyDBContext>(options => options.UseNpgsql(strCon));

            Services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            Services.AddScoped<IBaseRepository<Filme>, BaseRepository<Filme>>();
            Services.AddScoped<IBaseRepository<Sala>, BaseRepository<Sala>>();
            Services.AddScoped<IBaseRepository<Sessao>, BaseRepository<Sessao>>();
            Services.AddScoped<IBaseRepository<Ingresso>, BaseRepository<Ingresso>>();

            Services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();
            Services.AddScoped<IBaseService<Filme>, BaseService<Filme>>();
            Services.AddScoped<IBaseService<Sala>, BaseService<Sala>>();
            Services.AddScoped<IBaseService<Sessao>, BaseService<Sessao>>();
            Services.AddScoped<IBaseService<Ingresso>, BaseService<Ingresso>>();

            Services.AddSingleton(new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Genero, Genero>();
                cfg.CreateMap<Filme, Filme>();
                cfg.CreateMap<Sala, Sala>();
                cfg.CreateMap<Sessao, Sessao>();
                cfg.CreateMap<Ingresso, Ingresso>();
            },NullLoggerFactory.Instance).CreateMapper());


            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}
