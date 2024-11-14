using StupidTemplate.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace qwerty_menu.Mods
{
    internal class spazhands
    {
        public static void SpazHands()
        {
            GorillaTagger.Instance.offlineVRRig.leftHand.trackingPositionOffset.x = UnityEngine.Random.Range(0f, 360f);
            GorillaTagger.Instance.offlineVRRig.leftHand.trackingPositionOffset.y = UnityEngine.Random.Range(0f, 360f);
            GorillaTagger.Instance.offlineVRRig.leftHand.trackingPositionOffset.z = UnityEngine.Random.Range(0f, 360f);
            GorillaTagger.Instance.offlineVRRig.rightHand.trackingPositionOffset.x = UnityEngine.Random.Range(0f, 360f);
            GorillaTagger.Instance.offlineVRRig.rightHand.trackingPositionOffset.y = UnityEngine.Random.Range(0f, 360f);
            GorillaTagger.Instance.offlineVRRig.rightHand.trackingPositionOffset.z = UnityEngine.Random.Range(0f, 360f);
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }
    }
}
