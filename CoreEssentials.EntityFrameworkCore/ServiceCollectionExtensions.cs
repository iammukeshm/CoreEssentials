using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoreEssentials.EntityFrameworkCore
{
    public static class ServiceCollectionExtensions
    {
        public static void AddContext<T>(this IServiceCollection services, Action<DbContextOptionsBuilder> options) where T : DbContext
        {
            services.AddDbContextPool<T>(options);

            services.BuildServiceProvider().GetRequiredService<T>().Database.Migrate();
        }

        public static void AddContextMemory<T>(this IServiceCollection services) where T : DbContext
        {
            services.AddDbContextPool<T>(options => options.UseInMemoryDatabase(typeof(T).Name));

            services.BuildServiceProvider().GetRequiredService<T>().Database.EnsureCreated();
        }
    }
}
