using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetSectorSysOp : SysOpBase
    {
        private Sector s;
        public Sector Result { get; set; }

        public GetSectorSysOp(Sector s)
        {
            this.s = s;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Sector)broker.Get(s);

        }
    }
}
