using System;
using System.Collections.Generic;
using System.Text;

namespace flower_mods.Mods
{
    internal class longarmsoff
    {
        public static void Longarmsoff()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new UnityEngine.Vector3(1f, 1f, 1f);
        }
    }
}
