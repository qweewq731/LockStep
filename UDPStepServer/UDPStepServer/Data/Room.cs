using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPStepServer
{
    public class Room
    {
        /// <summary>
        /// 当前链接的客户端数据
        /// </summary>
        public UDPClientData[] ClientData;
        /// <summary>
        /// 当前房间状态
        /// </summary>
        public RoomType RoomState;

        public int maxPlayersCount;
        public int currentPlayersCount;
        public long roomUID;
    }
}
