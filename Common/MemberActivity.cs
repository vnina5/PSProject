using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class MemberActivity : IEntity
    {
        public Member Member { get; set; }
        public Activity Activity { get; set; }
        public Project Project { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateCompleted { get; set; }

        public string TableName => "memberactivity";

        public string InsertValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public object PrimaryKey => throw new NotImplementedException();

        public object ForeignKey => throw new NotImplementedException();

        public string Criteria => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public object InsertColumn => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
