using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum StatusActivity
    {
        Unassigned,
        Assigned,
        Completed
    }

    [Serializable]
    public class Activity : IEntity
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public string Name { get; set; }
        public int PlannedDuration { get; set; }
        public int ActualDuration { get; set; } = 0;
        public int Points { get; set; }
        public StatusActivity Status { get; set; } = StatusActivity.Unassigned;

        public string TableName => "activity";

        public object InsertColumn => "name, project, plannedduration, actualduration, points, status";

        public string InsertValues => $"'{Name}', '{Project.Id}', '{PlannedDuration}', '{ActualDuration}', '{Points}', '{Status}'";

        public string UpdateValues => $"name = '{Name}', plannedduration = '{PlannedDuration}', actualduration = '{ActualDuration}', points = '{Points}', status = '{Status}'";

        public object PrimaryKey => "id";

        public object ForeignKey => "project";

        public object ForeignKey2 => throw new NotImplementedException();

        public string Criteria => $"project = '{Project.Id}'";

        public string Search => $"status";


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Activity
                {
                    Id = (int)reader["Id"],
                    Project = new Project
                    {
                        Id = (int)reader["Project"],
                    },
                    Name = (string)reader["Name"],
                    //Description = (string)reader["Description"],
                    PlannedDuration = reader["PlannedDuration"] == DBNull.Value ? 0 : (int)reader["PlannedDuration"],
                    ActualDuration = reader["ActualDuration"] == DBNull.Value ? 0 : (int)reader["ActualDuration"],
                    Points = (int)reader["Points"],
                    Status = (StatusActivity)Enum.Parse(typeof(StatusActivity), (string)reader["Status"]),
                });
            }
            return list;
        }

        public List<IEntity> GetJoinEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Activity
                {
                    Id = (int)reader[0],
                    Project = new Project
                    {
                        Id = (int)reader[12],
                        Name = (string)reader[13],
                        Description = (string)reader[14],
                        DateStart = reader[15] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[15],
                        DateEnd = reader[16] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[16],
                        Duration = reader[17] == DBNull.Value ? 0 : (int)reader[17],
                    },
                    Name = (string)reader[2],
                    PlannedDuration = reader[3] == DBNull.Value ? 0 : (int)reader[3],
                    ActualDuration = reader[4] == DBNull.Value ? 0 : (int)reader[4],
                    Points = (int)reader[5],
                    Status = (StatusActivity)Enum.Parse(typeof(StatusActivity), (string)reader[6]),
                });
            }
            return list;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            Activity result = new Activity();
            while (reader.Read())
            {
                result.Id = (int)reader["Id"];
                result.Project = new Project
                {
                    Id = (int)reader["Project"],
                };
                result.Name = (string)reader["Name"];
                //result.Description = (string)reader["Description"];
                result.PlannedDuration = reader["PlannedDuration"] == DBNull.Value ? 0 : (int)reader["PlannedDuration"];
                result.ActualDuration = reader["ActualDuration"] == DBNull.Value ? 0 : (int)reader["ActualDuration"];
                result.Points = (int)reader["Points"];
                result.Status = (StatusActivity)reader["Status"];
            }
            return result;
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
