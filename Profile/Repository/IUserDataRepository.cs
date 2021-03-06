using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Profile.Repository
{
    public interface IUserDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        //TEntity Get(long id);
        //void Add(TEntity entity);
        //void Update(TEntity dbEntity, TEntity entity);
        //void Delete(TEntity entity);
    }
}
