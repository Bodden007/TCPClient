using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using TCPClient;

internal class Program
{
    private static void Main(string[] args)
    {
        int port;
        Class1 class1 = new Class1();

        if (args.Length < 1)
        {
            Console.Error.WriteLine("Нет аргументов, введите номер порта:");
            port = int.Parse(Console.ReadLine()!);
            Console.WriteLine("port: " + port);
        }
        else
        {
            port = int.Parse(args[0]);
            Console.WriteLine("port: " + port);
        }
        class1.Connect(port);

        // Console.WriteLine("\n Press Enter to continue...");
        // Console.Read();
    }
}