using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetMemberSysOp : SysOpBase
    {
        private Member m;
        public Member Result { get; set; }

        public GetMemberSysOp(Member m)
        {
            this.m = m;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Member)broker.Get(m);

        }
    }
}
