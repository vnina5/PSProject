using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class LoginSysOp : SystemOperationBase
    {
        private User user;
        public List<User> Result { get; set; }
        public LoginSysOp(User user) 
        { 
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetCriteria(user).OfType<User>().ToList();
            //Result = new User
            //{
            //    Id = 1,
            //    Name = "Pera Peric",
            //    Username = "pera",
            //    Password = "pera",
            //};
        }
    }
}
