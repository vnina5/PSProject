using Broker;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public abstract class SysOpBase
    {
        protected IBroker<IEntity> broker;
        //public object Result { get; set; }

        public SysOpBase() 
        {
            broker = new GenericBroker();
        }

        public void Execute()
        {
            try
            {
                ExecuteConcreteOperation();
                broker.Commit();
            }
            catch (Exception ex)
            {
                broker.Rollback();
                throw ex;
            }
            finally
            {
                broker.Close();
            }
        }

        protected abstract void ExecuteConcreteOperation();


    }
}
