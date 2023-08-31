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
        public void Connect(int port)
        {
            string? message;
            TcpClient client = new TcpClient("localhost", port);

            NetworkStream stream = client.GetStream();

            try
            {
                while (true)
                {


                    message = Console.ReadLine();

                    Byte[] data = System.Text.Encoding.ASCII.GetBytes($"{message}\n");

                    stream.Write(data, 0, data.Length);

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
                        message!.Remove(0);
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

            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
    }
}
