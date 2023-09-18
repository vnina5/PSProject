using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IEntity
    {
        string TableName { get; }
        object InsertColumn { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        object PrimaryKey { get; }
        object ForeignKey { get; }
        object ForeignKey2 { get; }
        string Criteria { get; }
        string Search { get; }

        List<IEntity> GetEntities(SqlDataReader reader);
        List<IEntity> GetJoinEntities(SqlDataReader reader);    
        IEntity GetEntity(SqlDataReader reader);
        IEntity GetJoinEntity(SqlDataReader reader);
        
    }
}
