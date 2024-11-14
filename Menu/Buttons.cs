using StupidTemplate.Classes;
using StupidTemplate.Mods;
using flower_mods.Mods;
using static StupidTemplate.Settings;
using qwerty_menu.Mods;
namespace qwerty_menu.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "opens the settings"},
                new ButtonInfo { buttonText = "platforms", method =() => platforms.Platforms(), toolTip = "platforms ig", isTogglable = true},
                new ButtonInfo { buttonText = "speedboost", method =() => Speedboost.SpeedboostMod(), toolTip = "gives you a speedboost", isTogglable = true},
                new ButtonInfo { buttonText = "fly (A)", method =() => Gogetemrufus.GoGetEmRufus(), toolTip = "makes you fly", isTogglable = true},
                new ButtonInfo { buttonText = "noclip (RT)", method =() => noclip.Noclip(), toolTip = "lets you noclip on left trigger", isTogglable = true},
                new ButtonInfo { buttonText = "no finger movement (NW)", method =() => nofingermovement.NoFinger(), toolTip = "stops finger movement", isTogglable = true},
                new ButtonInfo { buttonText = "ghost", method =() => ghost.GhostMonke(), toolTip = "makes your rig freeze in place like a ghost", isTogglable = true},
                new ButtonInfo { buttonText = "spaz head", method =() => spazhead.SpazHead(), disableMethod =() => spazheadoff.SpazHeadOff(), toolTip = "makes your head go lwufaslhwsujkhljkuywflhyw", isTogglable = true},
                new ButtonInfo { buttonText = "spaz hands", method =() => spazhands.SpazHands(), disableMethod =() => spazhandsoff.SpazHandsOff(), toolTip = "makes your hands go awerfhousdiuhyfrsagsl", isTogglable = true},
                new ButtonInfo { buttonText = "long arms", enableMethod =() => longarms.Longarms(),   disableMethod =() => longarmsoff.Longarmsoff(), toolTip = "gives you long arms", isTogglable = true},
                new ButtonInfo { buttonText = "kick all (D!)", method =() => kickall.KickAll(), toolTip = "kicks everyone", isTogglable = true},
                new ButtonInfo { buttonText = "lag all (D!)", method =() => kickall.KickAll(), toolTip = "lags everyone", isTogglable = true},
                new ButtonInfo { buttonText = "wasd fly", method =() => wasdfly.WASDFly(), toolTip = "fly with your keyboard", isTogglable = true},
                new ButtonInfo { buttonText = "grab player info", method =() => grabplayerinfo.GrabPlayerInfo(), toolTip = "grabs player info", isTogglable = true},
                new ButtonInfo { buttonText = "test", toolTip = "test" },
            },
            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "returns to the main page of the menu"},
                new ButtonInfo { buttonText = "menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "opens the settings for the menu"},
            },
            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "return to settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "right hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "puts the menu on your right hand."},
                new ButtonInfo { buttonText = "notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "toggles the notifications"},
                new ButtonInfo { buttonText = "fps counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "toggles the fps counter"},
            },
        };
    }
}
