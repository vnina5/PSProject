using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class FilterActivitiesOfProjectSysOp : SystemOperationBase
    {
        private readonly Activity a;
        private readonly StatusActivity status;
        public List<Activity> Result { get; set; }
        public FilterActivitiesOfProjectSysOp(StatusActivity status, int projectId)
        {
            this.status = status;
            a = new Activity();
            a.Project = new Project();
            a.Project.Id = projectId;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.FilterCriteria(a, status).OfType<Activity>().ToList();
        }
    }
}
