using Domain.Repositories;
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

        }

    }
}