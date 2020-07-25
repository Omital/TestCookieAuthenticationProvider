using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AdsTest.EntityFramework.Repositories
{
    public abstract class AdsTestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AdsTestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AdsTestRepositoryBase(IDbContextProvider<AdsTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AdsTestRepositoryBase<TEntity> : AdsTestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AdsTestRepositoryBase(IDbContextProvider<AdsTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
