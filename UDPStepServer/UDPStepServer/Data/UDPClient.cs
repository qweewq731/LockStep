

namespace UDPStepServer
{
    public struct UDPClientData
    {
        /// <summary>
        /// 玩家ID
        /// </summary>
        public long UUID { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public long Address { get; set; }
        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 连接状态
        /// </summary>
        public bool Connect { get; set; }
    }
}
