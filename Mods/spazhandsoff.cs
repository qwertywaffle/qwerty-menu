using StupidTemplate.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace qwerty_menu.Mods
{
    internal class spazhandsoff
    {
        public static void SpazHandsOff()
        {
            GorillaTagger.Instance.offlineVRRig.leftHand.trackingPositionOffset.x = UnityEngine.Random.Range(0f, 0f);
            GorillaTagger.Instance.offlineVRRig.leftHand.trackingPositionOffset.y = UnityEngine.Random.Range(0f, 0f);
            GorillaTagger.Instance.offlineVRRig.leftHand.trackingPositionOffset.z = UnityEngine.Random.Range(0f, 0f);
            GorillaTagger.Instance.offlineVRRig.rightHand.trackingPositionOffset.x = UnityEngine.Random.Range(0f, 0f);
            GorillaTagger.Instance.offlineVRRig.rightHand.trackingPositionOffset.y = UnityEngine.Random.Range(0f, 0f);
            GorillaTagger.Instance.offlineVRRig.rightHand.trackingPositionOffset.z = UnityEngine.Random.Range(0f, 0f);
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }
    }
}
