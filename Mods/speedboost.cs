using System;
using System.Collections.Generic;
using System.Text;

namespace flower_mods.Mods
{
    internal class Speedboost
    {
        public static void SpeedboostMod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }
    }
}
