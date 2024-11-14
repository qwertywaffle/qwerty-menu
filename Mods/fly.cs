using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace flower_mods.Mods
{
    internal class Gogetemrufus
    {
        public static void GoGetEmRufus()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 10f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}