using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class CompletMemberActivitySysOp : SystemOperationBase
    {
        private readonly List<MemberActivity> list;
        public CompletMemberActivitySysOp(List<MemberActivity> list)
        {
            this.list = list;
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach (MemberActivity ma in list)
            {
                broker.Update(ma, ma.Activity.Id);
                broker.Update(ma.Activity, ma.Activity.Id);
                broker.Update(ma.Member, ma.Member.Id);
            }
            
        }
    }
}
