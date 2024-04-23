using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace UDPStepServer
{
    public class UDP
    {
        Socket socket;

        private void Init()
        {
            //获得本机IP
            string hostAdressName = Dns.GetHostName();
            var adress = Dns.GetHostAddresses(hostAdressName);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(new IPEndPoint(adress.FirstOrDefault(), 8001));
        }
        

        ///发送
        private void Sender(byte[] sendBuffer,UDPClientData data)
        {
            IPEndPoint sendTo = new IPEndPoint(data.Address, data.Port);
            socket.SendTo(sendBuffer, sendTo);
        }

        /// <summary>
        /// 获得数据进行解析
        /// 需要返回成帧数据
        /// </summary>
        private void Reciver()
        { 
            
        }


    }
}