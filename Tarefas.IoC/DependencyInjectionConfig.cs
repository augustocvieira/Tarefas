using System;
using Microsoft.Extensions.DependencyInjection;
using Tarefas.Application.Interfaces.Repositories;
using Tarefas.Application.Interfaces.Services;
using Tarefas.Application.Services;
using Tarefas.Infrastructure.Repositories;

namespace Tarefas.IoC
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ITarefaService, TarefaService>();
            services.AddScoped<ITarefaRepository, TarefaRepository>();
        }

    }

    
}
