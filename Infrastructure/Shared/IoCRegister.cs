using Microsoft.EntityFrameworkCore;
using webapiTercero.Application.Interfaces.Repositories;
using webapiTercero.Application.Interfaces.Services;
using webapiTercero.Infrastructure.Contexts;
using webapiTercero.Infrastructure.Repositories;
using webapiTercero.Infrastructure.Services;
using webapiTercero.Infrastructure.UnitOfWorks;

namespace webapiTercero.Infrastructure.Shared
{
    public static class IoCRegister
    {

        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            //Contexts
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Conexion")));


            //Repository
            services.AddRegisterRepository();

            //Services
            services.AddRegisterServices();
        }
        public static IServiceCollection AddRegisterRepository(this IServiceCollection services)
        {
            return services.AddScoped<ICustomerRepository,CustomerRepository>()
            .AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>))
            .AddScoped<IUnitOfWork,UnitOfWork>();
        }
        public static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            return services.AddScoped<ICustomerService,CustomerService>();
        }
        
    }
}