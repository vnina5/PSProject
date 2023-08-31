using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class UpdateMemberSysOp : SysOpBase
    {
        private readonly Member member;
        public UpdateMemberSysOp(Member member) 
        {
            this.member = member;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(member);
        }
    }
}
