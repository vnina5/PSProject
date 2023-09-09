using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker
{
    public interface IBroker<TEntity> where TEntity : class
    {
        void Commit();
        void Rollback();
        void Close();

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(TEntity entity);
        List<TEntity> GetAll(TEntity entity);
        List<TEntity> GetAllJoin(IEntity entity, IEntity joinEntity);
        List<TEntity> Search(string criteria);
    }
}
