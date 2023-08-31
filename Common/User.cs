using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string TableName => "[user]";

        public string Values => $"'{Name}', '{Username}','{Password}'";

        public string Criteria => $"username = '{Username}' and password = '{Password}'";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new User
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"]
                });
            }
            return list;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            User result = new User();
            while (reader.Read())
            {
                result.Id = (int)reader["Id"];
                result.Name = (string)reader["Name"];
                result.Username = (string)reader["Username"];
                result.Password = (string)reader["Password"];
            }
            return result;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
