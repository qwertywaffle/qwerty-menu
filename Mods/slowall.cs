using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using ExitGames.Client.Photon;
using GorillaGameModes;
using GorillaLocomotion.Gameplay;
using GorillaNetworking;
using HarmonyLib;
using qwerty_menu.Classes;
using qwerty_menu.Notifications;
using Photon.Pun;
using UnityEngine.InputSystem;
using static qwerty_menu.Classes.RigManager;
using static qwerty_menu.Menu.Main;

namespace qwerty_menu.Mods
{
    internal class slowall
    {
        private static float kgDebounce;

        public static void GayFurryFemboys()
        {
            if (Time.time > kgDebounce)
            {
                BetaSetStatus(0, new RaiseEventOptions { Receivers = ReceiverGroup.Others });
                RPCProtection();
                kgDebounce = Time.time + 1f;
            }
        }

        private static void BetaSetStatus(int v, RaiseEventOptions raiseEventOptions)
        {
            throw new NotImplementedException();
        }
    }
}
