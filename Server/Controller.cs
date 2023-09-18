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

        internal object LoginUser(User user)
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
        internal object GetMember(int id)
        {
            SystemOperationBase so = new GetMemberSysOp(id);
            so.Execute();
            return ((GetMemberSysOp)so).Result;
        }

        internal void AddMember(Member member)
        {
            SystemOperationBase so = new AddMemberSysOp(member);
            so.Execute();
        }

        internal void UpdateMember(Member member)
        {
            SystemOperationBase so = new UpdateMemberSysOp(member);
            so.Execute();
        }

        internal object GetAllSectors()
        {
            SystemOperationBase so = new GetAllSectorsSysOp();
            so.Execute();
            return ((GetAllSectorsSysOp)so).Result;
        }

        internal object GetSectors(int id)
        {
            SystemOperationBase so = new GetSectorSysOp(id);
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
            SystemOperationBase so = new UpdateProjectSysOp(project);
            so.Execute();
        }

        internal object GetActivitiesOfProject(int projectId)
        {
            SystemOperationBase so = new GetActivitiesOfProjectSysOp(projectId);
            so.Execute();
            return ((GetActivitiesOfProjectSysOp)so).Result;
        }

        internal void AddActivity(Activity activity)
        {
            SystemOperationBase so = new AddActivitySysOp(activity);
            so.Execute();
        }

        internal void UpdateActivity(Activity activity)
        {
            SystemOperationBase so = new UpdateActivitySysOp(activity);
            so.Execute();
        }

        internal void AssignMemberActivity(List<MemberActivity> listMemberActivityy)
        {
            SystemOperationBase so = new AssignMemberActivitySysOp(listMemberActivityy);
            so.Execute();
        }

        internal object GetMembersSearch(string criteria)
        {
            SystemOperationBase so = new SearchMembersSysOp(criteria);
            so.Execute();
            return ((SearchMembersSysOp)so).Result;
        }

        internal object GetProjectsSearch(string criteria)
        {
            SystemOperationBase so = new SearchProjectsSysOp(criteria);
            so.Execute();
            return ((SearchProjectsSysOp)so).Result;
        }

        internal object GetFilterActivitiesOfProject(StatusActivity status, int projectId)
        {
            SystemOperationBase so = new FilterActivitiesOfProjectSysOp(status, projectId);
            so.Execute();
            return ((FilterActivitiesOfProjectSysOp)so).Result;
        }

        internal object GetMemberActivities(Member member)
        {
            SystemOperationBase so = new GetMemberActivitiesSysOp(member);
            so.Execute();
            return ((GetMemberActivitiesSysOp)so).Result;
        }

        internal object GetActivityMembers(Activity activity)
        {
            SystemOperationBase so = new GetActivityMembersSysOp(activity);
            so.Execute();
            return ((GetActivityMembersSysOp)so).Result;
        }

        internal void CompletMemberActivity(List<MemberActivity> listMemberActivity)
        {
            SystemOperationBase so = new CompletMemberActivitySysOp(listMemberActivity);
            so.Execute();
        }
    }
}
