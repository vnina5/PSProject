using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetActivityMembersSysOp : SystemOperationBase
    {
        private readonly Activity a;
        public List<MemberActivity> Result { get; set; }

        public GetActivityMembersSysOp(Activity a)
        {
            this.a = a;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetOneJoin(new Member(), new MemberActivity(), a.Id).OfType<MemberActivity>().ToList();
        }
    }
}
