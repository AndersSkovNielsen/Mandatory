﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    class Server
    {
        private readonly int pORT = 10001;

        public Server()
        {

        }

        public void Start()
        {
            //Sætte server op
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, pORT);
            serverListener.Start();

            //Loop til at holde server kørende
            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();
                //Mulighed for flere klienter samtidig via async
                Task.Run(() => { TcpClient tempSocket = socket; DoClient(tempSocket); });
                //DoClient(/*TcpClient socket =*/ serverListener.AcceptTcpClient());
            }
        }

        public void DoClient(TcpClient socket /*= serverListener.AcceptTcpClient*/)
        {
            //using (TcpClient socket = serverListener.AcceptTcpClient())
            //Unødvendig da denne nu ligger i metodens parameter

            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))

            {
                String incomingString = sr.ReadToEnd();

                Console.WriteLine($"String in:\n{incomingString}");
            }
        }
    }
}
