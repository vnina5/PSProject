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

        public object InsertColumn => "name, plannedduration, actualduration, points, status";

        public string InsertValues => $"'{Name}', '{PlannedDuration}', '{ActualDuration}', '{Points}', '{Status}'";

        public string UpdateValues => $"name = '{Name}', plannedduration = '{PlannedDuration}', points = '{Points}'";

        public object PrimaryKey => "id";

        public object ForeignKey => "project";

        public string Criteria => $"project = '{Project.Id}'";

        public object ForeignKey2 => throw new NotImplementedException();


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Activity
                {
                    Id = (int)reader["Id"],
                    //Project = (int)reader["Project"],
                    Name = (string)reader["Name"],
                    //Description = (string)reader["Description"],
                    PlannedDuration = reader["PlannedDuration"] == DBNull.Value ? 0 : (int)reader["PlannedDuration"],
                    ActualDuration = reader["ActualDuration"] == DBNull.Value ? 0 : (int)reader["ActualDuration"],
                    Points = (int)reader["Points"],
                    Status = (StatusActivity)reader["Status"]
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
                //result.Project = (int)reader["Project"];
                result.Name = (string)reader["Name"];
                //result.Description = (string)reader["Description"];
                result.PlannedDuration = reader["PlannedDuration"] == DBNull.Value ? 0 : (int)reader["PlannedDuration"];
                result.ActualDuration = reader["ActualDuration"] == DBNull.Value ? 0 : (int)reader["ActualDuration"];
                result.Points = (int)reader["Points"];
                result.Status = (StatusActivity)reader["Status"];
            }
            return result;
        }
    }
}
