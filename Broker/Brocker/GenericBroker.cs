using Broker.Connection;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            cmd.CommandText = $"insert into {entity.TableName} ({entity.InsertColumn}) values ({entity.InsertValues})";
            cmd.ExecuteNonQuery();
        }

        public void Update(IEntity entity, object id)
        {
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"update {entity.TableName} set {entity.UpdateValues} where {entity.PrimaryKey} = '{id}'";
            cmd.ExecuteNonQuery();
        }

        //--
        public void Delete(IEntity entity, object id)
        {
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"delete from {entity.TableName} where {entity.PrimaryKey} = '{id}'";
            cmd.ExecuteNonQuery();
        }

        public List<IEntity> Search(IEntity entity, string criteria)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} where lower({entity.Search}) like lower('{criteria}%')";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> SearchJoin(IEntity entity, IEntity joinEntity, string criteria)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} a join {joinEntity.TableName} b on (a.{entity.ForeignKey} = b.{joinEntity.PrimaryKey}) where lower({entity.Search}) like lower('{criteria}%')";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetJoinEntities(reader);
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

        public List<IEntity> GetCriteria(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} where {entity.Criteria}";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public IEntity GetOne(IEntity entity, object id)
        {
            IEntity result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} where {entity.PrimaryKey} = '{id}'";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntity(reader);
            reader.Close();
            return result;
        }


        public List<IEntity> GetAllJoin(IEntity entity, IEntity joinEntity)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} a join {joinEntity.TableName} b on (a.{entity.ForeignKey} = b.{joinEntity.PrimaryKey})";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetJoinEntities(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> GetOneJoin(IEntity entity, IEntity joinEntity, IEntity joinEntity2, object criteria)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} a join {joinEntity.TableName} b on (a.{entity.PrimaryKey} = b.{joinEntity.ForeignKey2}) join {joinEntity2.TableName} c on (a.{entity.ForeignKey} = c.{joinEntity2.PrimaryKey}) where b.{joinEntity.ForeignKey} = {criteria}";
            SqlDataReader reader = cmd.ExecuteReader();
            result = joinEntity.GetEntities(reader);
            reader.Close();
            return result;
        }

        //--
        //public IEntity GetOneJoin(IEntity entity, IEntity joinEntity, object id)
        //{
        //    IEntity result;
        //    SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
        //    cmd.CommandText = $"select * from {entity.TableName} a join {joinEntity.TableName} b on (a.{entity.ForeignKey} = b.{joinEntity.PrimaryKey}) where {entity.ForeignKey} = '{id}'";
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    result = entity.GetJoinEntity(reader);
        //    reader.Close();
        //    return result;
        //}

        //--
        //join 2
        //select * from MemberActivity a join Activity b on (a.Activity = b.Id and a.Project = b.Project) join Member c on (a.Member = c.Id)
        public List<IEntity> GetTwoJoin(IEntity entity, IEntity joinEntity, IEntity joinEntity2, object criteria)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {joinEntity.TableName} a join {entity.TableName} b on (a.{joinEntity.PrimaryKey} = b.{entity.ForeignKey}) join {joinEntity2.TableName} c on (a.{joinEntity.ForeignKey} = c.{joinEntity2.PrimaryKey}) where b.{entity.ForeignKey2} = {criteria} ";
            SqlDataReader reader = cmd.ExecuteReader();
            result = joinEntity.GetJoinEntities(reader);
            reader.Close();
            return result;
        }

        public object GetMaxId(IEntity entity)
        {
            object pk;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select max({entity.PrimaryKey}) from {entity.TableName}";
            pk = cmd.ExecuteScalar();
            return pk;
        }

        public List<IEntity> FilterCriteria(IEntity entity, object criteria)
        {
            List<IEntity> result;
            SqlCommand cmd = DbBroker.Instance.GetConnection().GetCommand();
            cmd.CommandText = $"select * from {entity.TableName} where {entity.Criteria} and {entity.Search} = '{criteria}'";
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }


    }
}
