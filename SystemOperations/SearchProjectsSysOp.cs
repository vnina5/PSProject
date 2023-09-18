using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SearchProjectsSysOp : SystemOperationBase
    {
        private readonly string criteria;
        public List<Project> Result { get; set; }
        public SearchProjectsSysOp(string criteria)
        {
            this.criteria = criteria;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Search(new Project(), criteria).OfType<Project>().ToList();
        }
    }
}
