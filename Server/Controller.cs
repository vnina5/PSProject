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
            SystemOperationBase so = new LoginSysOp(user);
            so.Execute();
            return ((LoginSysOp)so).Result;
        }

        internal object GetAllMembers()
        {
            SystemOperationBase so = new GetAllMembersSysOp();
            so.Execute();
            return ((GetAllMembersSysOp)so).Result;
        }
        internal object GetMember(Member member)
        {
            SystemOperationBase so = new GetMemberSysOp(member);
            so.Execute();
            return ((GetMemberSysOp)so).Result;
        }

        internal void AddMember(Member member)
        {
            SystemOperationBase so = new AddMemberSysOp(member);
            so.Execute();
            //return so.Result;
        }

        internal void UpdateMember(Member member)
        {
            SystemOperationBase so = new UpdateMemberSysOp(member);
            so.Execute();
            //return so.Result;
        }

        internal object GetAllSectors()
        {
            SystemOperationBase so = new GetAllSectorsSysOp();
            so.Execute();
            return ((GetAllSectorsSysOp)so).Result;
        }

        internal object GetSectors(Sector sector)
        {
            SystemOperationBase so = new GetSectorSysOp(sector);
            so.Execute();
            return ((GetSectorSysOp)so).Result;
        }

        internal object GetAllProjects()
        {
            SystemOperationBase so = new GetAllProjectsSysOp();
            so.Execute();
            return ((GetAllProjectsSysOp)so).Result;
        }

        internal void AddProject(Project project)
        {
            SystemOperationBase so = new AddProjectSysOp(project);
            so.Execute();
        }

        internal void UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
