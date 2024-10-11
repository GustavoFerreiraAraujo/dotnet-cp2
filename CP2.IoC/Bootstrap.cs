using CP2.Application.Services;
using CP2.Data.AppData;
using CP2.Data.Repositories;
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oracle.EntityFrameworkCore; // Esta linha deve estar presente

namespace CP2.IoC
{
    public static class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseOracle(configuration["ConnectionStrings:DefaultConnection"]); // Use a string de conexão correta
            });

            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IVendedorRepository, VendedorRepository>();
        }
    }
}
