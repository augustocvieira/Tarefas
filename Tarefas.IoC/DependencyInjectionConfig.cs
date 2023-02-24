using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tarefas.Application.Interfaces.Repositories;
using Tarefas.Application.Interfaces.Services;
using Tarefas.Application.Services;
using Tarefas.Infrastructure.Context;
using Tarefas.Infrastructure.Repositories;

namespace Tarefas.IoC
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServicesApi(IServiceCollection services, string connectionString)
        {
            services.AddScoped<ITarefaService, TarefaService>();
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
        }

    }

    
}
