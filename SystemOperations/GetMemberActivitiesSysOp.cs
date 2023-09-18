using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetMemberActivitiesSysOp : SystemOperationBase
    {
        private readonly Member m;
        public List<Activity> Result { get; set; }

        public GetMemberActivitiesSysOp(Member m)
        {
            this.m = m;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetTwoJoin(new MemberActivity(), new Activity(), new Project(), m.Id).OfType<Activity>().ToList();
        }
    }
}
