using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Sokoban
{
    public enum PhoneType
    {
        Client,
        Server
    }

    abstract class PhoneSock
    {
        protected NetworkStream ns;
        protected string host;
        protected int port;
        protected PhoneType type;

        public deRecv Recv;
        public bool isConnected;
        public deLog Log;
        public Socket handler;


        public void Start()
        {
            Thread thread = new Thread(Waiter);
            thread.IsBackground = true;
            thread.Start();
        }

        private void Waiter()
        {
            while(true)
            {
                Connect();

                if (!isConnected)
                    continue;

                while (true)
                {
                    try
                    {
                        byte[] bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);

                        string data = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        if (data == "disconnect")
                        {
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }
                        {
                            Log("data received " + data);
                            Recv(data);
                        }
                    }
                    catch (Exception e)
                    {
                        Log(e.ToString());
                        Thread.Sleep(100);
                        break;
                    }
                }
            }
        }

        abstract public void Connect();

        public bool Send(string data)
        {
            try
            {   
                byte[] msg = Encoding.UTF8.GetBytes(data);
                handler.Send(msg);
                Log("send data " + msg.ToString());
                return true;
            }
            catch 
            {
                Log("data not send " + data.ToString());
                Thread.Sleep(100);
                
                return false;
            }
          
        }

        public bool IsServer()
        {
            return (type == PhoneType.Server);
        }

        public bool IsClient()
        {
            return (type == PhoneType.Client);
        }

    }

    class PhoneSockServer : PhoneSock
    {
        IPEndPoint ipEndPoint;
        Socket listener;

        public PhoneSockServer(int port)
        {
            //this.Log = Log;
            this.port = port;
            this.type = PhoneType.Server;
        }

        override public void Connect()
        {
            ipEndPoint = new IPEndPoint(IPAddress.Any, port);
            if (listener == null)
            {
                listener = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(ipEndPoint);
                listener.Listen(1);
            }

            try
            {
                handler = listener.Accept();
                isConnected = true;
                Log("connection is alive\n");
            }
            catch (Exception e)
            {
                isConnected = false;
                Log("connection lost\n" + e.ToString());
            }
        }
    }

    class PhoneSockClient : PhoneSock
    {
        IPEndPoint ipEndPoint;

        public PhoneSockClient(string host, int port)
        {
            //this.Log = Log;
            this.host = host;
            this.port = port;
            this.type = PhoneType.Client;
        }

        override public void Connect()
        {
            try
            {
                ipEndPoint = new IPEndPoint(IPAddress.Parse(host), port);
                handler = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                handler.Connect(ipEndPoint);
                isConnected = true;
                Log("connection connect");
            }
            catch (Exception e)
            {
                isConnected = false;
                Log(e.ToString());
            }
        }

    }
}

