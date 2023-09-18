using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Sector : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string TableName => "sector";

        public object InsertColumn => "name";

        public string InsertValues => $"'{Name}'";

        public string UpdateValues => $"name = {Name}";

        public object PrimaryKey => "id";

        public object ForeignKey => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => $"id = {Id}";
        
        public string Search => "name";


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Sector
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"]
                });
            }
            return list;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            Sector result = new Sector();
            while (reader.Read())
            {
                result.Id = (int)reader["Id"];
                result.Name = (string)reader["Name"];
            }
            return result;
        }

        public List<IEntity> GetJoinEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetJoinEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
