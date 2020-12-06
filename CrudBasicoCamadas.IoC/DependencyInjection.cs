using BaseCrudCamadas.Repository.SqlServer;
using BaseCrudCamadas.Repository.SqlServer.UnityOfWork;
using CrudBasicoCamadas.Domain.Interfaces.IRepository;
using CrudBasicoCamadas.Domain.Interfaces.IService;
using CrudBasicoCamadas.Domain.Interfaces.IUnityOfWork;
using CrudBasicoCamadas.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrudBasicoCamadas.IoC
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IUnityOfWork>(options => new UnityOfWork(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();


        }
    }
}
