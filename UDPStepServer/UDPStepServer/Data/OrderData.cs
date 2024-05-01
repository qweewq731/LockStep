using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPStepServer.Data
{
    /// <summary>
    /// 考虑一下角色当期奥状态，如果没有输入，我们是沿用之前的指令集？
    /// 使用密文状态去发送指令，每个指令其实是{Reciver,target,}
    /// </summary>
    public class OrderDataBase
    {
        //帧数
        public int tick { get; set; }
        //当前玩家的指令
        //操作不一定有接受者但是一定有操作的人
        public int roleUID { get; set; } 
    }
}
