using Photon.Pun;
using StupidTemplate.Classes;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace qwerty_menu.Mods
{
    internal class grabplayerinfo
    {
        public static void GrabPlayerInfo()
        {
            string text = "Room: " + PhotonNetwork.CurrentRoom.Name;
            foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerList)
            {
                float num = 0f;
                float num2 = 0f;
                float num3 = 0f;
                string text2 = "";
                try
                {
                    VRRig vrrigFromPlayer = RigManager.GetVRRigFromPlayer(player);
                    num = vrrigFromPlayer.playerColor.r * 255f;
                    num2 = vrrigFromPlayer.playerColor.g * 255f;
                    num3 = vrrigFromPlayer.playerColor.b * 255f;
                    text2 = vrrigFromPlayer.concatStringOfCosmeticsAllowed;
                }
                catch
                {
                }
                try
                {
                    text += "\n====================================\n";
                    text = string.Concat(new string[]
                    {
                text,
                "player name: \"",
                player.NickName,
                "\", player id: \"",
                player.UserId,
                "\", player color: (r: ",
                num.ToString(),
                ", g: ",
                num2.ToString(),
                ", b: ",
                num3.ToString(),
                "), cosmetics: ",
                text2
                    });
                }
                catch
                {
                }
            }
            text += "\n====================================\n";
            text += "file generated with qwerty's menu";
            string text3 = "iisStupidMenu/PlayerInfo/" + PhotonNetwork.CurrentRoom.Name + ".txt";
            bool flag = !Directory.Exists("iisStupidMenu");
            if (flag)
            {
                Directory.CreateDirectory("iisStupidMenu");
            }
            bool flag2 = !Directory.Exists("iisStupidMenu/PlayerInfo");
            if (flag2)
            {
                Directory.CreateDirectory("iisStupidMenu/PlayerInfo");
            }
            File.WriteAllText(text3, text);
            string text4 = Path.Combine(Assembly.GetExecutingAssembly().Location, text3);
            text4 = text4.Split("BepInEx\\", 0)[0] + text3;
            try
            {
                Process.Start(text4);
            }
            catch
            {
            }
        }
    }
}
