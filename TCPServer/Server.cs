using Components;
using System;
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
                Console.WriteLine("Server\n");

                //Request n' Response #1
                String incomingString = sr.ReadLine();

                Console.WriteLine($"String in:\n{incomingString}");

                SplitAndCalculate(incomingString, sw);

                //Request n' Response #2
                String incomingString2 = sr.ReadLine();

                Console.WriteLine($"String in:\n{incomingString2}");

                SplitAndCalculate(incomingString2, sw);
            }
        }
        private void SplitAndCalculate(string aString, StreamWriter sw)
        {
            string[] split = aString.Split(' ');

            if (split[0] == "ToGrams")
            {
                double result = Converter.ToGrams(Convert.ToDouble(split[1]));

                Console.WriteLine($"Sending result: " + result);

                sw.WriteLine($"Result: " + result);
                sw.Flush();
            }

            if (split[0] == "ToOunces")
            {
                double result = Converter.ToOunces(Convert.ToDouble(split[1]));

                Console.WriteLine($"Sending result: " + result);

                sw.WriteLine($"Result: " + result);
                sw.Flush();
            }
        }
    }
}
