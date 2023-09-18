using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetMemberSysOp : SystemOperationBase
    {
        private readonly int id;
        public Member Result { get; set; }
        public GetMemberSysOp(int id)
        {
            this.id = id;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Member)broker.GetOne(new Member(), id);

        }
    }
}
