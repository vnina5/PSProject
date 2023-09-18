using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetActivitiesOfProjectSysOp : SystemOperationBase
    {
        private readonly Activity a;
        public List<Activity> Result { get; set; }
        public GetActivitiesOfProjectSysOp(int projectId)
        {
            a = new Activity();
            a.Project = new Project();
            a.Project.Id = projectId;
        }

        protected override void ExecuteConcreteOperation()
        {            
            Result = broker.GetCriteria(a).OfType<Activity>().ToList();
        }
    }
}
