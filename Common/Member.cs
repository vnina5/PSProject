using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Year
    {
        I = 1,
        II = 2,
        III = 3,
        IV = 4
    }

    [Serializable]
    public class Member : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Year YearOfStudy { get; set; }
        public Sector Sector { get; set; }

        public string TableName => "member";

        public string Values => $"(firstname, lastname, dateofbirth, yearofstudy, sector) values ('{FirstName}', '{LastName}','{DateOfBirth.ToString("yyyyMMdd")}', '{(int)YearOfStudy}', '{Sector.Id}')";

        public string Criteria => $"id = {Id}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Member
                {
                    Id = (int)reader["Id"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                    YearOfStudy = (Year)reader["YearOfStudy"],
                    Sector = new Sector
                    {
                        Id = (int)reader["Sector"],
                        //Name = "sektor 1"
                    }
                });
            }
            return list;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            Member result = new Member();
            while (reader.Read())
            {
                result.Id = (int)reader["Id"];
                result.FirstName = (string)reader["FirstName"];
                result.LastName = (string)reader["LastName"];
                result.DateOfBirth = (DateTime)reader["DateOfBirth"];
                result.YearOfStudy = (Year)reader["YearOfStudy"];
                result.Sector = new Sector
                {
                    Id = (int)reader["Sector"]
                };
            }
            return result;
        }
    }
}
