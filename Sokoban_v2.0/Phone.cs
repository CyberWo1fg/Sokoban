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
    abstract class Phone
    {
        protected NetworkStream ns;
        protected string host;
        protected int port;
        public deRecv Recv;
        public bool isConnected;
        public deLog Log;

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
                while (true)
                {
                    try
                    {
                        int data = ns.ReadByte();
                        if (data != -1)
                        {
                            Log("data received " + ((byte)data).ToString());
                            //Recv((byte)data);
                        }
                            

                    }
                    catch
                    {
                        Log("data not received");
                        Thread.Sleep(100);
                        break;
                    }
                }


            }
        }

        abstract public void Connect();

        public bool Send(byte data)
        {
            try
            {
                ns.WriteByte(data);
                Log("send data " + data.ToString());
                return true;
            }
            catch 
            {
                Log("data not send " + data.ToString());
                Thread.Sleep(100);
                
                return false;
            }
          
        }
    }

    class PhoneServer : Phone
    {
        public PhoneServer(deLog Log, int port)
        {
            this.Log = Log;
            this.port = port;
            
        }

        override public void Connect()
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                listener.Start(1);
                TcpClient client = listener.AcceptTcpClient();
                ns = client.GetStream();
                isConnected = true;
                Log("connection connect");
            }
            catch 
            {
                isConnected = false;
                Log("connection lost");
            }
        }
    }

    class PhoneClient : Phone
    {
        public PhoneClient(deLog Log, string host, int port)
        {
            this.Log = Log;
            this.host = host;
            this.port = port;

        }

        override public void Connect()
        {
            try
            {
                TcpClient client = new TcpClient(host, port);
                ns = client.GetStream();
                isConnected = true;
                Log("connection connect");
            }
            catch
            {
                isConnected = false;
                Log("connection lost");
            }
        }
    }
}

