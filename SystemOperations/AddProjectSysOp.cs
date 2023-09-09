using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddProjectSysOp : SystemOperationBase
    {
        private readonly Project p;

        public AddProjectSysOp(Project p)
        {
            this.p = p;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(p);
            foreach (Activity a in p.ActivityList)
            {
                a.Project = p;
                broker.Add(a);
            }
        }
    }
}
