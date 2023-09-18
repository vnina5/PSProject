using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UpdateProjectSysOp : SystemOperationBase
    {
        private readonly Project p;
        public UpdateProjectSysOp(Project p)
        {
            this.p = p;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(p, p.Id);
            //update activity
            //...
        }
    }
}
