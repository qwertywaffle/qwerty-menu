using BepInEx;
using System.ComponentModel;

namespace qwerty_menu.Patches
{
    [Description(qwerty_menu.PluginInfo.Description)]
    [BepInPlugin(qwerty_menu.PluginInfo.GUID, qwerty_menu.PluginInfo.Name, qwerty_menu.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
