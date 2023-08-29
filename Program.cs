using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using TCPClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Class1 class1 = new Class1();
        class1.Connect();
    }
}