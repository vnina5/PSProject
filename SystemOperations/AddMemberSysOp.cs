using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class AddMemberSysOp : SystemOperationBase
    {
        private readonly Member m;

        public AddMemberSysOp(Member m) 
        {
            this.m = m;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(m);
        }
    }
}
