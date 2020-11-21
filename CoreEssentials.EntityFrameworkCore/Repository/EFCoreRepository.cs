using CoreEssentials.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;

namespace CoreEssentials.EntityFrameworkCore.Repository
{
    public class EFCoreRepository<T> : Repository<T> where T : class
    {
        public EFCoreRepository(DbContext context) : base(new EFCoreCommandRepository<T>(context), new EFCoreQueryRepository<T>(context))
        {
        }
    }
}