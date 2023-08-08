using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client
{
    class OurClient
    {
        private TcpClient client;
        private StreamWriter sWriter;
    
        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 8080);
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

            HandleCommunication();
        }
        void HandleCommunication()
        {
            while(true)
            {
                Console.Write("> ");
                string message = Console.ReadLine()!;
                sWriter.WriteLine(message);
                sWriter.Flush();
            }
        }
    }
}