using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarioWorld.SuperMarioU.Characters
{
    class Kinopiko : PlayerCharacter, IPrincessPeach
    {
        public void FloatingJump()
        {
            // 執行漂浮跳躍該做的指令
            Console.WriteLine("Kinopiko.FloatingJump()");
        }

        public void DoubleJump()
        {
            // 執行兩段跳躍該做的指令
            Console.WriteLine("Kinopiko.DoubleJump()");
        }
    }
}
