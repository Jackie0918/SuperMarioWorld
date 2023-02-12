using SuperMarioWorld.SuperMarioU.Enums;
using System;

namespace SuperMarioWorld.SuperMarioU.Characters
{
    class Character
    {
        public void Move(MoveType moveType)
        {
            // 執行移動位置的要做的指令
            // ...

            switch (moveType)
            {
                case MoveType.Walk:
                    // 執行走路該做的指令
                    Console.WriteLine("Character.Move(MoveType.Walk)");
                    break;
                case MoveType.Run:
                    // 執行跑步該做的指令
                    Console.WriteLine("Character.Move(MoveType.Run)");
                    break;
                case MoveType.Dash:
                    // 執行衝刺該做的指令
                    Console.WriteLine("Character.Move(MoveType.Dash)");
                    break;
                case MoveType.Swim:
                    // 執行游泳該做的指令
                    Console.WriteLine("Character.Move(MoveType.Swim)");
                    break;
                default:
                    // 其他狀況
                    break;
            }
        }
    }
}
