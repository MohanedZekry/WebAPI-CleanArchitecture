using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlacementTest.Application.Repository;
using PlacementTest.Application.Repository.TestTakersRepository;
using PlacementTest.Persistence.Context;
using PlacementTest.Persistence.Repository;
using PlacementTest.Persistence.Repository.TestTakersRepository;

namespace PlacementTest.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("PlacementTestContext");
            services.AddDbContext<PlacementTestContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITestTakerRepository, TestTakerRepository>();
        }
    }
}
