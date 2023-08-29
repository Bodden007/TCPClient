using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Class1
    {
        public void Connect()

        {
            Int32 port = 2014;

            string? message;

            //TcpClient client = new TcpClient();
            TcpClient client = new TcpClient("localhost", port);
            ////IPAddress ipAddr = IPAddress.Parse("localhost");
            ////client.Connect(adressL, port);
            //NetworkStream stream = client.GetStream();

           // IPAddress ipAddr = IPAddress.Parse("127.0.0.1");
           // client.Connect(ipAddr, port);

            NetworkStream stream = client.GetStream();

            try
            {
                while (true)
                {
                    

                    message = Console.ReadLine();

                   Byte[] data = System.Text.Encoding.ASCII.GetBytes($"{message}\n");
                    //Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                    stream.Write(data, 0, data.Length);
                    //stream.Flush();

                    Console.WriteLine("Sent: {0}", message);

                    int res = string.Compare(message, "stop");

                    if (res == 0)
                    {
                        stream.Close();
                        client.Close();
                        break;
                    }
                    else
                    {
                        message.Remove(0);
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                
            }
            finally
            {
                //stream.Close();
                //client.Close();

            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
    }
}
