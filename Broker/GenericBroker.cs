using Broker.Connection;
using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker
{
    public class GenericBroker : IBroker<IEntity>
    {
        
        public void Commit()
        {
            DbBroker.Instance.GetConnection().Commit();
        }

        public void Rollback()
        {
            DbBroker.Instance.GetConnection().Rollback();
        }

        public void Close()
        {
            DbBroker.Instance.GetConnection().Close();
        }

        public void Add(IEntity entity)
        {
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"insert into {entity.TableName} {entity.Values}";
            cmd.ExecuteNonQuery();
        }

        public void Update(IEntity entity)
        {
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"update {entity.TableName} set {entity.Values} where {entity.Criteria}";
            cmd.ExecuteNonQuery();
        }

        public void Delete(IEntity entity)
        {
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"delete from {entity.TableName} where {entity.Criteria}";
            cmd.ExecuteNonQuery();
        }

        public IEntity Get(IEntity entity)
        {
            IEntity result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} where {entity.Criteria}";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntity(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName}";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> Search(string criteria)
        {
            throw new NotImplementedException();
        }



    }
}
