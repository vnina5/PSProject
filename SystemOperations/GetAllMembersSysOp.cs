using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class GetAllMembersSysOp : SysOpBase
    {
        public List<Member> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Member()).OfType<Member>().ToList();
        }
    }
}
