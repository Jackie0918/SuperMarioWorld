using SuperMarioWorld.SuperMarioU.Characters;
using SuperMarioWorld.SuperMarioU.Enums;
using System;

namespace SuperMarioWorld.SuperMarioU
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario marioForJackie = new Mario();
            Mario marioForRichard = new Mario();
            Nabbit nabbitForThomas = new Nabbit();
            Kinopiko kinopikoForEric = new Kinopiko();

            marioForJackie.Jump();
            marioForRichard.Jump();
            marioForRichard.Move(MoveType.Swim);
            kinopikoForEric.Glide();
            nabbitForThomas.Glide();
            kinopikoForEric.FloatingJump();

            Console.WriteLine(); // method overloading的例子：Method名稱都是WriteLine()，但是參數的個數和型別可以不同
            Console.WriteLine("Jackie's Mario's life count: " + marioForJackie.LifeCount);
            Console.WriteLine("Richard's Mario's life count: " + marioForRichard.LifeCount);
            Console.WriteLine("Thomas' Nabbit's life count: " + nabbitForThomas.LifeCount);
            Console.WriteLine("Eric's Kinopiko's life count: " + kinopikoForEric.LifeCount);
            marioForJackie.LifeCountMinusOne();
            marioForRichard.LifeCountPlusOne();
            nabbitForThomas.LifeCountPlusOne();
            kinopikoForEric.LifeCountPlusOne();
            kinopikoForEric.LifeCountPlusOne();
            Console.WriteLine("Jackie's Mario's life count: " + marioForJackie.LifeCount);
            Console.WriteLine("Richard's Mario's life count: " + marioForRichard.LifeCount);
            Console.WriteLine("Thomas' Nabbit's life count: " + nabbitForThomas.LifeCount);
            Console.WriteLine("Eric's Kinopiko's life count: " + kinopikoForEric.LifeCount);

            Console.ReadLine();
        }
    }
}
