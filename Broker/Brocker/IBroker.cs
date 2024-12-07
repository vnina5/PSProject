﻿using Common;
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
        void Update(IEntity entity, object id);
        void Delete(TEntity entity, object id);
        List<TEntity> Search(TEntity entity, string criteria);
        List<TEntity> SearchJoin(TEntity entity, TEntity joinEntity, string criteria);
        List<IEntity> FilterCriteria(TEntity entity, object criteria);

        List<TEntity> GetAll(TEntity entity);
        List<IEntity> GetCriteria(TEntity entity);
        TEntity GetOne(TEntity entity, object id);

        List<TEntity> GetAllJoin(IEntity entity, IEntity joinEntity);
        List<IEntity> GetOneJoin(IEntity entity, IEntity joinEntity, IEntity joinEntity2, object criteria);
        List<IEntity> GetTwoJoin(IEntity entity, IEntity joinEntity, IEntity joinEntity2, object criteria);

        object GetMaxId(TEntity entity);

    }
}
