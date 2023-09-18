using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
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
        public DateTime DateCompleted { get; set; } = DateTime.Now;
        
        public string TableName => "memberactivity";
        
        public object InsertColumn => "member, activity, project, dateassigned, datecompleted";

        public string InsertValues => $"'{Member.Id}', '{Activity.Id}', '{Project.Id}', '{DateAssigned:yyyyMMdd}', '{DateCompleted:yyyyMMdd}'";

        public string UpdateValues => $"datecompleted = '{DateCompleted:yyyyMMdd}'";

        public object PrimaryKey => "activity";

        public object ForeignKey => "activity";

        public object ForeignKey2 => "member";

        public string Criteria => throw new NotImplementedException();

        public string Search => throw new NotImplementedException();


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new MemberActivity
                {
                    Member = new Member
                    {
                        Id = (int)reader[0],
                        FirstName = (string)reader[1],
                        LastName = (string)reader[2],
                        Email = reader[3].ToString(),
                        Password = reader[4].ToString(),
                        YearOfStudy = (Year)reader[5],
                        NumOfActivities = reader[6] == DBNull.Value ? 0 : (int)reader[6],
                        HoursOfWork = reader[7] == DBNull.Value ? 0 : (int)reader[7],
                        Points = reader[8] == DBNull.Value ? 0 : (int)reader[8],
                        Sector = new Sector
                        {
                            Id = (int)reader[9],
                            //Name = reader[14].ToString(),
                        }
                    },
                    DateAssigned = reader[13] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[13],
                    DateCompleted = reader[14] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[14],
                    Activity = new Activity
                    {
                        Id = (int)reader[11],
                        Project = new Project 
                        { 
                            Id = (int)reader[12], 
                        }
                    }
                });
            }
            return list;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetJoinEntities(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new MemberActivity
                {
                    Activity = new Activity
                    {
                        Id = (int)reader[0],
                        Name = (string)reader[2],
                        PlannedDuration = reader[3] == DBNull.Value ? 0 : (int)reader[3],
                        ActualDuration = reader[4] == DBNull.Value ? 0 : (int)reader[4],
                        Points = (int)reader[5],
                        Status = (StatusActivity)Enum.Parse(typeof(StatusActivity), (string)reader[6]),
                    },
                    DateAssigned = reader[10] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[10],
                    DateCompleted = reader[11] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[11],
                    Project = new Project
                    {
                        Id = (int)reader[12],
                        Name = (string)reader[13],
                        Description = (string)reader[14],
                        DateStart = reader[15] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[15],
                        DateEnd = reader[16] == DBNull.Value ? DateTime.MinValue : (DateTime)reader[16],
                        Duration = reader[17] == DBNull.Value ? 0 : (int)reader[17],
                    },  
                    Member = new Member
                    {
                        Id = (int)reader[7],
                    }
                });
            }
            return list;
        }

        public IEntity GetJoinEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
