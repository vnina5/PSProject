using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket socketServer;

        public Server() 
        {
            
        }

        public void Start()
        {
            try
            {
                socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
                socketServer.Bind(ep);

                socketServer.Listen(10);

                Thread listener = new Thread(Listen);
                listener.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Listen()
        {
            while (true)
            {
                Socket socketClient = socketServer.Accept();
                ClientHandler handler = new ClientHandler(socketClient);
                Thread thread = new Thread(handler.HandleRequest);
                thread.Start();
            }
        }

        public void Stop()
        {
            socketServer.Close();
        }
    
    
    }
}
