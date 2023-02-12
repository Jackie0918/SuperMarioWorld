using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarioWorld.SuperMarioU.Characters
{
    class Nabbit : PlayerCharacter
    {
        public override void Glide()  // Override的例子
        {
            // 什麼都不做，因為Nabbit不可能會滑翔
            Console.WriteLine("Nabbit.Glide(): Do nothing");
            return;
        }
    }
}
