using CalculoCDB.Application.Queries.Concrete;
using CalculoCDB.Application.Queries.Interfaces;
using MediatR;

namespace CalculoCDB.Api.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static void AddRegisterServices(this IServiceCollection services)
        {

            services.AddTransient<IMediator, Mediator>();
            services.AddScoped<ICDBQuery, CDBQuery>();
        }
    }
}
