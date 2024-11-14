using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace flower_mods.Mods
{
    internal class noclip
    {
        public static void Noclip()
        {
            if (ControllerInputPoller.TriggerFloat(UnityEngine.XR.XRNode.RightHand) >= 0.5f)
            {
                foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider2.enabled = true;
                }
            }
        }

    }
}
