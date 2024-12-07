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
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int Duration { get; set; } = 0;
        public BindingList<Activity> ActivityList { get; set; } = new BindingList<Activity>();

        public string TableName => "project";

        public object InsertColumn => "name, description, datestart, dateend, duration";

        public string InsertValues => $"'{Name}', '{Description}', '{DateStart.ToString("yyyyMMdd")}', '{DateEnd.ToString("yyyyMMdd")}', '{Duration}'";

        public string UpdateValues => $"name = '{Name}', description = '{Description}', datestart = '{DateStart.ToString("yyyyMMdd")}', dateend = '{DateEnd.ToString("yyyyMMdd")}', duration = '{Duration}'";

        public object PrimaryKey => "id";

        public object ForeignKey => throw new NotImplementedException();

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => $"id = '{Id}'";
       
        public string Search => "name";


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Project
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"],
                    DateStart = reader["DateStart"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["DateStart"],
                    DateEnd = reader["DateEnd"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["DateEnd"],
                    Duration = reader["Duration"] == DBNull.Value ? 0 : (int)reader["Duration"],
                });
            }
            return list;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            Project result = new Project();
            while (reader.Read())
            {
                result.Id = (int)reader["Id"];
                result.Name = (string)reader["Name"];
                result.Description = (string)reader["Description"];
                result.DateStart = reader["DateStart"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["DateStart"];
                result.DateEnd = reader["DateEnd"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["DateEnd"];
                result.Duration = reader["Duration"] == DBNull.Value ? 0 : (int)reader["Duration"];
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
