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
        public Dictionary<string, UDPClientData[]> DataDic;

        /// <summary>
        /// 取消连接
        /// </summary>
        public void DisConnect(string adress,UDPClientData data)
        {
            if (DataDic.TryGetValue(adress, out UDPClientData[] GropData))
            {
                for (int i = 0; i < GropData.Length; i++)
                {
                    if (GropData[i].UUID == data.UUID)
                    {
                        GropData[i].Connect = false;
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
            if (DataDic.TryGetValue(adress, out UDPClientData[] GropData))
            {
                for (int i = 0; i < GropData.Length; i++)
                {
                    if (GropData[i].UUID == data.UUID)
                    {
                        GropData[i].Address = data.Address;
                        GropData[i].Port = data.Port;
                        GropData[i].Connect = true;
                    }
                }
            }
        }
    }
}
