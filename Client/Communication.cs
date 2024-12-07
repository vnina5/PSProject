using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class Communication
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        private Communication() { }

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9988);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal List<User> LoginUser(string username, string password)
        {
            Request request = new Request();
            request.Operation = Operation.Login;
            request.Object = new User
            {
                Username = username,
                Password = password
            };
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if(response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<User>)response.Result;

        }

        internal List<Member> GetAllMembers()
        {
            Request request = new Request();
            request.Operation = Operation.GetAllMembers;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Member>)response.Result;
        }

        internal void AddMember(Member member)
        {
            Request request = new Request();
            request.Operation = Operation.AddMember;
            request.Object = member;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal void UpdateMember(Member member)
        {
            Request request = new Request();
            request.Operation = Operation.UpdateMember;
            request.Object = member;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal List<Sector> GetAllSectors()
        {
            Request request = new Request();
            request.Operation = Operation.GetAllSectors;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Sector>)response.Result;
        }

        internal List<Project> GetAllProjects()
        {
            Request request = new Request();
            request.Operation = Operation.GetAllProjects;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Project>)response.Result;
        }

        internal void AddProject(Project project)
        {
            Request request = new Request();
            request.Operation = Operation.AddProject;
            request.Object = project;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal void UpdateProject(Project project)
        {
            Request request = new Request();
            request.Operation = Operation.UpdateProject;
            request.Object = project;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal BindingList<Activity> GetActivitiesOfProject(int projectId)
        {
            Request request = new Request();
            request.Operation = Operation.GetActivitiesOfProject;
            request.Object = projectId;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return new BindingList<Activity>((List<Activity>)response.Result);
        }

        internal void AssignMemberActivity(List<MemberActivity> listMemberActivity)
        {
            Request request = new Request();
            request.Operation = Operation.AssignMemberActivity;
            request.Object = listMemberActivity;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal void CompletMemberActivity(List<MemberActivity> listMemberActivity)
        {
            Request request = new Request();
            request.Operation = Operation.CompletMemberActivity;
            request.Object = listMemberActivity;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal void UpdateActivity(Activity activity)
        {
            Request request = new Request();
            request.Operation = Operation.UpdateActivity;
            request.Object = activity;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal List<Member> GetMembersSearch(string criteria)
        {
            Request request = new Request();
            request.Operation = Operation.GetMembersSearch;
            request.Object = criteria;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Member>)response.Result;
        }

        internal List<Project> GetProjectsSearch(string criteria)
        {
            Request request = new Request();
            request.Operation = Operation.GetProjectsSearch;
            request.Object = criteria;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Project>)response.Result;
        }

        internal BindingList<Activity> GetFilterActivitiesOfProject(StatusActivity status, int projectId)
        {
            Request request = new Request();
            request.Operation = Operation.GetFilterActivitiesOfProject;
            object[] array = { status, projectId };
            request.Object = array;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return new BindingList<Activity>((List<Activity>)response.Result);
        }

        internal List<Activity> GetMemberActivities(Member member)
        {
            Request request = new Request();
            request.Operation = Operation.GetMemberActivities;
            request.Object = member;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Activity>)response.Result;
        }

        internal List<MemberActivity> GetActivityMembers(Activity activity)
        {
            Request request = new Request();
            request.Operation = Operation.GetActivityMembers;
            request.Object = activity;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<MemberActivity>)response.Result;
        }


    }
}
