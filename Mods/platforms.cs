using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace qwerty_menu.Mods
{
    internal class platforms
    {
        public static void Platforms()
        {
            if (ControllerInputPoller.instance.rightGrab && Rplat == null)
            {
                Rplat = GameObject.CreatePrimitive((PrimitiveType)3);
                Rplat.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                Rplat.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 0);
                Rplat.transform.position = GorillaTagger.Instance.rightHandTransform.position + new Vector3(0f, 0f, 0f);
                Rplat.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                Rplat.transform.localScale = new Vector3(0.02f, 0.4f, 0.4f);
            }
            else if (!ControllerInputPoller.instance.rightGrab && Rplat != null)
            {
                UnityEngine.Object.Destroy(Rplat);
                Rplat = null;
            }
            if (ControllerInputPoller.instance.leftGrab && Lplat == null)
            {
                Lplat = GameObject.CreatePrimitive((PrimitiveType)3);
                Lplat.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                Lplat.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 0);
                Lplat.transform.position = GorillaTagger.Instance.leftHandTransform.position + new Vector3(0f, 0f, 0f);
                Lplat.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                Lplat.transform.localScale = new Vector3(0.02f, 0.4f, 0.4f);
                return;
            }
            if (!ControllerInputPoller.instance.leftGrab && Lplat != null)
            {
                UnityEngine.Object.Destroy(Lplat);
                Lplat = null;
            }
        }

        public static GameObject Lplat;
        public static GameObject Rplat;
    }
}
