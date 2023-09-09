using Common;
using System.ComponentModel;
using SysOp;
using System.Linq;
using System.Collections.Generic;

namespace Server
{
    public class GetAllSectorsSysOp : SystemOperationBase
    {
        public List<Sector> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Sector()).OfType<Sector>().ToList();
        }
    }
}