using Common;
using System;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request request = receiver.Receive<Request>();
                    Response response = ProcessRequest(request);
                    sender.Send(response);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();

            try
            {
                switch (request.Operation)
                {
                    case Operation.End:
                        response.Result = "The end!";
                        break;

                    case Operation.Login:
                        response.Result = Controller.Instance.LoginUser((User)request.Object);
                        break;

                    case Operation.GetAllMembers:
                        response.Result = Controller.Instance.GetAllMembers();
                        break;

                    case Operation.GetMember:
                        response.Result = Controller.Instance.GetMember((Member)request.Object);
                        break;

                    case Operation.AddMember:
                        Controller.Instance.AddMember((Member)request.Object);
                        break;

                    case Operation.UpdateMember:
                        Controller.Instance.UpdateMember((Member)request.Object);
                        break;

                    case Operation.GetAllSectors:
                        response.Result = Controller.Instance.GetAllSectors();
                        break;

                    case Operation.GetSector:
                        response.Result = Controller.Instance.GetSectors((Sector)request.Object);
                        break;

                    case Operation.GetAllProjects:
                        response.Result = Controller.Instance.GetAllProjects();
                        break;

                    case Operation.AddProject:
                        Controller.Instance.AddProject((Project)request.Object);
                        break;

                    case Operation.UpdateProject:
                        Controller.Instance.UpdateProject((Project)request.Object);
                        break;

                    default:
                        response.Exception = new Exception("Operation is not implemented!");
                        break;
                }
            }
            catch (Exception ex)
            {
                response.Exception = new Exception(ex.Message);
                //throw;
            }

            return response;
        }
    }
}