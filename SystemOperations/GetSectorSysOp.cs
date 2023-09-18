using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetSectorSysOp : SystemOperationBase
    {
        private readonly int id;
        public Sector Result { get; set; }
        public GetSectorSysOp(int id)
        {
            this.id = id;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Sector)broker.GetOne(new Sector(), id);

        }
    }
}
