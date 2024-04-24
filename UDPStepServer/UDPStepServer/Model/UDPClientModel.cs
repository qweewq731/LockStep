using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPStepServer
{
    internal class UDPClientModel
    {
        /// <summary>
        /// 对应的房间号和玩家ID，方便传输
        /// </summary>
        public Dictionary<string, Room> DataDic;

        /// <summary>
        /// 取消连接
        /// </summary>
        public void DisConnect(string adress,UDPClientData data)
        {
            if (DataDic.TryGetValue(adress, out Room Room))
            {
                for (int i = 0; i < Room.ClientData.Length; i++)
                {
                    if (Room.ClientData[i].UUID == data.UUID)
                    {
                        Room.ClientData[i].Connect = false;
                    }
                }
            }
        }

        /// <summary>
        /// 考虑到断线重连 不能直接给数据清除
        /// </summary>
        /// <param name="adress"></param>
        /// <param name="data"></param>
        public void ReConnect(string adress, UDPClientData data)
        {
            if (DataDic.TryGetValue(adress, out Room Room))
            {
                for (int i = 0; i < Room.ClientData.Length; i++)
                {
                    if (Room.ClientData[i].UUID == data.UUID)
                    {
                        Room.ClientData[i].Address = data.Address;
                        Room.ClientData[i].Port = data.Port;
                        Room.ClientData[i].Connect = true;
                    }
                }
            }
        }
    }
}
