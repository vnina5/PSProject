using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class LoginSysOp : SysOpBase
    {
        private User user;

        public User Result { get; set; }

        public LoginSysOp(User user) 
        { 
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (User)broker.Get(user);
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
