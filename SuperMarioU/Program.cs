using SuperMarioWorld.SuperMarioU.Characters;
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
            kinopikoForEric.Glide();
            nabbitForThomas.Glide();

            Console.ReadLine();
        }
    }
}
