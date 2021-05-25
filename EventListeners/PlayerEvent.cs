using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;

namespace RFVanillaUIDisabler.EventListeners
{
    public static class PlayerEvent
    {
        public static void OnConnected(UnturnedPlayer player)
        {
            if (!player.HasPermission(Plugin.Conf.Permission)) return;
            if (Plugin.Conf.DisableFood)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
            if (Plugin.Conf.DisableHealth)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
            if (Plugin.Conf.DisableOxygen)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
            if (Plugin.Conf.DisableStamina)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
            if (Plugin.Conf.DisableVirus)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
            if (Plugin.Conf.DisableWater)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
            if (Plugin.Conf.DisableDeathMenu)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowDeathMenu);
            if (Plugin.Conf.DisableGunStatus)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowUseableGunStatus);
            if (Plugin.Conf.DisableStatusIcon)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
            if (Plugin.Conf.DisableVehicleStatus)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVehicleStatus);
            if (Plugin.Conf.DisableInteractWithEnemy)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowInteractWithEnemy);
        }
    }
}