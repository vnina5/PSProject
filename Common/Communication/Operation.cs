using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Operation
    {
        End,
        Login,
        GetAllMembers,
        AddMember,
        UpdateMember,
        GetAllSectors,
        GetSector,
        GetMember,
        GetAllProjects,
        AddProject,
        UpdateProject,
        GetActivitiesOfProject,
        AddActivity,
        UpdateActivity,
        AssignMemberActivity,
        GetMembersSearch,
        GetProjectsSearch,
        GetActivitiesSearch,
        GetFilterActivitiesOfProject,
        GetMemberActivities,
        GetActivityMembers,
        CompletMemberActivity,
    }
}
