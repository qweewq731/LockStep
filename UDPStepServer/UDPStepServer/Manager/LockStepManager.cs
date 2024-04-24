using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPStepServer
{
    public class LockStepManager
    {
        UDP _udp;

        UDPClientModel _clientModel;
        public void Init()
        {
            _udp = new UDP();
            _clientModel = new UDPClientModel();
        }

        /// <summary>
        /// 游戏运行
        /// </summary>
        public void Update() 
        {

        }
    }
}
