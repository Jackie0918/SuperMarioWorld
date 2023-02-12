using SuperMarioWorld.SuperMarioU.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarioWorld.SuperMarioU.Characters
{
    class PlayerCharacter : Character
    {
        private int lifeCount = 3;
        public BodySize BodySize = BodySize.Normal;
        public bool IsInAcronHat = false;
        public bool IsPowerful = false;

        public int LifeCount { get { return lifeCount; } }
        public void LifeCountPlusOne()
        {
            lifeCount++;
        }
        public void LifeCountMinusOne()
        {
            if (lifeCount > 0)
            {
                lifeCount--;
            }
        }

        public void Crouch()
        {
            // 執行蹲下該做的指令
            Console.WriteLine("PlayerCharacter.Crouch()");
        }

        public void Jump()
        {
            // 執行跳躍該做的指令
            Console.WriteLine("PlayerCharacter.Jump()");
        }

        public void SpinJump()
        {
            // 執行旋轉跳躍該做的指令
            Console.WriteLine("PlayerCharacter.SpinJump()");
        }

        public void WallJump()
        {
            // 執行踢強跳躍該做的指令
            Console.WriteLine("PlayerCharacter.WallJump()");
        }

        public void GroundPound()
        {
            // 執行臀部撞地該做的指令
            Console.WriteLine("PlayerCharacter.GroundPound()");
        }

        public virtual void Glide()
        {
            // 執行滑翔該做的指令
            Console.WriteLine("PlayerCharacter.Glide()");
        }

    }
}
