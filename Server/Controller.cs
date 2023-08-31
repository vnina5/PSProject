using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOp;
using SystemOperations;

namespace Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }

        internal User LoginUser(User user)
        {
            SysOpBase so = new LoginSysOp(user);
            so.Execute();
            return ((LoginSysOp)so).Result;
        }

        internal object GetAllMembers()
        {
            SysOpBase so = new GetAllMembersSysOp();
            so.Execute();
            return ((GetAllMembersSysOp)so).Result;
        }
        internal object GetMember(Member member)
        {
            SysOpBase so = new GetMemberSysOp(member);
            so.Execute();
            return ((GetMemberSysOp)so).Result;
        }

        internal void AddMember(Member member)
        {
            SysOpBase so = new AddMemberSysOp(member);
            so.Execute();
            //return so.Result;
        }

        internal void UpdateMember(Member member)
        {
            SysOpBase so = new UpdateMemberSysOp(member);
            so.Execute();
            //return so.Result;

        }

        internal object GetAllSectors()
        {
            SysOpBase so = new GetAllSectorsSysOp();
            so.Execute();
            return ((GetAllSectorsSysOp)so).Result;
        }

        internal object GetSectors(Sector sector)
        {
            SysOpBase so = new GetSectorSysOp(sector);
            so.Execute();
            return ((GetSectorSysOp)so).Result;
        }
    }
}
