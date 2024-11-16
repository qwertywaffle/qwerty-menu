using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace qwerty_menu.Mods
{
    internal class freezeall
    {

        // No, it's not skidded, read the debunk: https://pastebin.com/raw/FL5j8fcy
        private static bool lastfreezegarbage = false;
        private static float Garfield = 0f;
        public static void FreezeAll()
        {
            if (ControllerInputPoller.TriggerFloat(UnityEngine.XR.XRNode.RightHand) > 0.5f)
            {
                if (Time.time > Garfield)
                {
                    lastfreezegarbage = !lastfreezegarbage;
                    foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                    {
                        GorillaPlayerScoreboardLine.MutePlayer(line.linePlayer.UserId, line.linePlayer.NickName, lastfreezegarbage ? 1 : 0);
                    }
                    Garfield = Time.time + 0.1f;
                }
            }
        }

    }
}
