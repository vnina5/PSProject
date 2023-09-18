﻿using Common;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UpdateActivitySysOp : SystemOperationBase
    {
        private readonly Activity a;
        public UpdateActivitySysOp(Activity a) 
        {
            this.a = a;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(a, a.Id);
        }
    }
}
