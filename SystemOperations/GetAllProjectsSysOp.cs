using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetAllProjectsSysOp : SystemOperationBase
    {
        public List<Project> Result { get; set; }
        //public List<Activity> Act { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Project()).OfType<Project>().ToList();
        }
    }
}
