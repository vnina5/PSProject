using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SearchMembersSysOp : SystemOperationBase
    {
        private readonly string criteria;
        public List<Member> Result { get; set; }
        public SearchMembersSysOp(string criteria)
        {
            this.criteria = criteria;   
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.SearchJoin(new Member(), new Sector(), criteria).OfType<Member>().ToList();
        }
    }
}
