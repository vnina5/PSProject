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

        private Communication()
        {

        }

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9988);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal User LoginUser(string username, string password)
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
            return (User)response.Result;

        }

        internal BindingList<Member> GetAllMembers()
        {
            Request request = new Request();
            request.Operation = Operation.GetAllMembers;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (BindingList<Member>)response.Result;
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
    }
}
