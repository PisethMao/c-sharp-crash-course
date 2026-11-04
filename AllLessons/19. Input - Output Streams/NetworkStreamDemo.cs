using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FirstProgram._19._Input___Output_Streams;

public class NetworkStreamDemo
{
    private static async Task RunAsync()
    {
        TcpListener tcpListener = new(IPAddress.Loopback, 0);
        tcpListener.Start();
        try
        {
            var port = ((IPEndPoint)tcpListener.LocalEndpoint).Port;
            using TcpClient client = new();
            var connection = client.ConnectAsync(IPAddress.Loopback, port);
            using var server = await tcpListener.AcceptTcpClientAsync();
            await connection;
            await using var clientStream = client.GetStream();
            await using var serverStream = server.GetStream();
            var message = "Hello Server!"u8.ToArray();
            await clientStream.WriteAsync(message.AsMemory());
            var received = new byte[message.Length];
            await serverStream.ReadExactlyAsync(
                received, 0, received.Length);
            Console.WriteLine($"Server Received: " +
                              $"{Encoding.UTF8.GetString(received)}");
            var responseMessage = "Hello Client!"u8.ToArray();
            await serverStream.WriteAsync(responseMessage.AsMemory());
            var reply = new byte[responseMessage.Length];
            await clientStream.ReadExactlyAsync(
                reply, 0, reply.Length);
            Console.WriteLine($"Client Received: " +
                              $"{Encoding.UTF8.GetString(reply)}");
        }
        finally
        {
            tcpListener.Stop();
        }
    }

    public static void Run()
    {
        RunAsync().GetAwaiter().GetResult();
    }
}