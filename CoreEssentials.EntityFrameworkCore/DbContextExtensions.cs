using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreEssentials.EntityFrameworkCore
{
    public static class DbContextExtensions
    {
        public static IQueryable<T> QuerySet<T>(this DbContext context) where T : class
        {
            return context.DetectChangesLazyLoading(false).Set<T>().AsNoTracking();
        }

        public static DbSet<T> CommandSet<T>(this DbContext context) where T : class
        {
            return context.DetectChangesLazyLoading(true).Set<T>();
        }

        public static DbContext DetectChangesLazyLoading(this DbContext context, bool enabled)
        {
            context.ChangeTracker.AutoDetectChangesEnabled = enabled;

            context.ChangeTracker.LazyLoadingEnabled = enabled;

            context.ChangeTracker.QueryTrackingBehavior = enabled ? QueryTrackingBehavior.TrackAll : QueryTrackingBehavior.NoTracking;

            return context;
        }
    }
}