using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string Criteria { get; }

        List<IEntity> GetEntities(SqlDataReader reader);
        IEntity GetEntity(SqlDataReader reader);
    }
}
