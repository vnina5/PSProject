using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class GetAllMembersSysOp : SystemOperationBase
    {
        public List<Member> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            //Result = broker.GetAll(new Member()).OfType<Member>().ToList();
            Result = broker.GetAllJoin(new Member(), new Sector()).OfType<Member>().ToList();
        }
    }
}
