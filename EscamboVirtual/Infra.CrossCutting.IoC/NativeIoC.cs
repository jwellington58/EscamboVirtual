using Domain.Repositories;
using Domain.Services;
using Domain.Services.Impl;
using Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.CrossCutting.IoC
{
    public class NativeIoC
    {

        public static void RegisterServices(IServiceCollection services)
        {
            //Reporitories
            services.AddScoped<IAutorRepository, AutorRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IExemplarRepositoy, ExemplarRepository>();
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<ILivroAutorRepository, LivroAutorRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<ITrocaRepository, TrocaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            //Services

            services.AddScoped<IAutorService, AutorService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IExemplarService, ExemplarService>();
            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<ILivroAutorService, LivroAutorService>();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<ITrocaService, TrocaService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            //COntrollers


        }

    }
}