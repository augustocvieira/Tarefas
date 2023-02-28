using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tarefas.Application.Services;
using Tarefas.Infrastructure.Context;
using Tarefas.Infrastructure.Repositories;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.IoC
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServicesApi(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<RepositoryDbContext>(options => options.UseSqlServer(connectionString));
            RegisterRepositories(services);
            RegisterApplicationServices(services);
        }

        private static void RegisterApplicationServices(IServiceCollection services)
        {
            
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ITarefaService, TarefaService>();
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }

    
}
