using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;

namespace RFVanillaUIManager.EventListeners
{
    public static class PlayerEvent
    {
        public static void OnConnected(UnturnedPlayer player)
        {
            if (!player.HasPermission(Plugin.Conf.Permission)) 
                return;
            
            if (Plugin.Conf.HideFoodBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
            if (Plugin.Conf.HideHealthBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
            if (Plugin.Conf.HideOxygenBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
            if (Plugin.Conf.HideStaminaBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
            if (Plugin.Conf.HideVirusBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
            if (Plugin.Conf.HideWaterBar)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
            if (Plugin.Conf.HideDeathMenu)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowDeathMenu);
            if (Plugin.Conf.HideGunStatus)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowUseableGunStatus);
            if (Plugin.Conf.HideStatusIcon)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
            if (Plugin.Conf.HideVehicleStatus)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVehicleStatus);
            if (Plugin.Conf.HideInteractWithEnemy)
                player.Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowInteractWithEnemy);
        }
    }
}