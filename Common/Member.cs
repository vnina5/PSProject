using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string Email { get; set; }
        public string Password { get; set; }
        //public DateTime DateOfBirth { get; set; }
        public Year YearOfStudy { get; set; }
        public int NumOfActivities { get; set; } = 0;
        public int HoursOfWork { get; set; } = 0;
        public int Points { get; set; } = 0;
        public Sector Sector { get; set; }

        public string TableName => "member";

        public object InsertColumn => "firstname, lastname, email, password, yearofstudy, numofactivities, hoursofwork, points, sector";

        public string InsertValues => $"'{FirstName}', '{LastName}', '{Email}', '{Password}', '{(int)YearOfStudy}', '{NumOfActivities}', '{HoursOfWork}', '{Points}', '{Sector.Id}'";

        public string UpdateValues => $"firstname = '{FirstName}', lastname = '{LastName}', email = '{Email}', yearofstudy = '{(int)YearOfStudy}', sector = '{Sector.Id}'";

        public object PrimaryKey => "id";

        public object ForeignKey => "sector";

        public string Criteria => $"id = {Id}";

        public object ForeignKey2 => throw new NotImplementedException();


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            Member result = new Member();
            while (reader.Read())
            {
                list.Add(new Member
                {
                    Id = (int)reader["Id"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    //DateOfBirth = (DateTime)reader["DateOfBirth"],
                    YearOfStudy = (Year)reader["YearOfStudy"],
                    NumOfActivities = reader["NumOfActivities"] == DBNull.Value ? 0 : (int)reader["NumOfActivities"],
                    HoursOfWork = reader["HoursOfWork"] == DBNull.Value ? 0 : (int)reader["HoursOfWork"],
                    Points = reader["Points"] == DBNull.Value ? 0 : (int)reader["Points"],
                    Sector = new Sector
                    {
                        Id = (int)reader["Sector"],
                        Name = (string)reader["Name"]
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
                result.Email = (string)reader["Email"];
                result.Password = (string)reader["Password"];
                //result.DateOfBirth = (DateTime)reader["DateOfBirth"];
                result.YearOfStudy = (Year)reader["YearOfStudy"];
                result.NumOfActivities = reader["NumOfActivities"] == DBNull.Value ? 0 : (int)reader["NumOfActivities"];
                result.HoursOfWork = reader["HoursOfWork"] == DBNull.Value ? 0 : (int)reader["HoursOfWork"];
                result.Points = reader["Points"] == DBNull.Value ? 0 : (int)reader["Points"];
                result.Sector = new Sector
                {
                    Id = (int)reader["Sector"],
                    Name = (string)reader["Name"]
                };
            }
            return result;
        }


        public override string ToString()
        {
            return FirstName + " " + LastName;
        }


    }
}
