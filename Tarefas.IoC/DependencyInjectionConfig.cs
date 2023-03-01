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
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IServiceManager, ServiceManager>();
        }
    }

    
}
