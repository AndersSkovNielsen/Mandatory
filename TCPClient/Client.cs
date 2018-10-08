using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Client
    {
        public Client()
        {

        }

        public void Start()
        {
            //Indsæt aktuel kode nedenfor. Nedenfor er skabelon eksempel.
            //Car c = new Car("Tesla", "Red", "EL23400");

            //Car c1 = new Car("Mercedes", "Yellow", "AutoSaleCar3");
            //Car c2 = new Car("Volvo", "Purple", "AutoSaleCar4");

            //List<Car> cList = new List<Car> { c1, c2 };

            //AutoSale sale = new AutoSale("Matthews", "Conway 31", cList);

            using (TcpClient socket = new TcpClient("localhost", 10001))

            using (NetworkStream ns = socket.GetStream())

            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))

            {
                Console.WriteLine("Client\n");

                //Request #1
                double grams = 222.55;

                string request = $"ToGrams " + grams;

                Console.WriteLine(request);

                sw.WriteLine(request);
                sw.Flush();

                string line = sr.ReadLine();

                Console.WriteLine(line);

                //Request #2
                double ounces = 55.22;

                string request2 = $"ToOunces " + ounces;

                Console.WriteLine(request2);

                sw.WriteLine(request2);
                sw.Flush();

                string line2 = sr.ReadLine();

                Console.WriteLine(line2);
            }
        }
    }
}
