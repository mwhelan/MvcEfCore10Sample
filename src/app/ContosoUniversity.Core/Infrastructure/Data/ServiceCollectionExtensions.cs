using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ContosoUniversity.Core.Infrastructure.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(connectionString));
        }
    }
}
