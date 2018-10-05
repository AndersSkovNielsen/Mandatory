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
                sw.WriteLine($"ToGrams: " + 15);
                sw.Flush();

                sw.WriteLine($"ToOunces: " + 15);
                sw.Flush();
            }
        }
    }
}
