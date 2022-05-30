using System;
using RFVanillaUIManager.EventListeners;
using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Logger = Rocket.Core.Logging.Logger;

namespace RFVanillaUIManager
{
    public class Plugin : RocketPlugin<Configuration>
    {
        private static int Major = 1;
        private static int Minor = 0;
        private static int Patch = 1;
        
        public static Plugin Inst;
        public static Configuration Conf;

        protected override void Load()
        {
            Inst = this;
            Conf = Configuration.Instance;
            if (Conf.Enabled)
            {
                    U.Events.OnPlayerConnected += PlayerEvent.OnConnected;
                
                if (Level.isLoaded)
                    foreach (var steamPlayer in Provider.clients)
                        PlayerEvent.OnConnected(UnturnedPlayer.FromSteamPlayer(steamPlayer));
            }
            else
                Logger.LogWarning($"[{Name}] Plugin: DISABLED");

            Logger.LogWarning($"[{Name}] Plugin loaded successfully!");
            Logger.LogWarning($"[{Name}] {Name} v{Major}.{Minor}.{Patch}");
            Logger.LogWarning($"[{Name}] Made with 'rice' by RiceField Plugins!");
        }
        protected override void Unload()
        {
            if (Conf.Enabled)
            {
                    U.Events.OnPlayerConnected -= PlayerEvent.OnConnected;
                
                if (Conf.RevertOnUnload)
                    EnableVanillaUI();
            }
            
            Inst = null;
            Conf = null;
            
            Logger.LogWarning($"[{Name}] Plugin unloaded successfully!");
        }

        private void EnableVanillaUI()
        {
            try
            {
                foreach (var steamPlayer in Provider.clients)
                {
                    var player = UnturnedPlayer.FromSteamPlayer(steamPlayer);
                    
                    if (Conf.HideFoodBar)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
                    
                    if (Conf.HideHealthBar)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
                    
                    if (Conf.HideOxygenBar)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
                    
                    if (Conf.HideStaminaBar)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
                    
                    if (Conf.HideVirusBar)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
                    
                    if (Conf.HideWaterBar)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
                    
                    if (Conf.HideDeathMenu)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowDeathMenu);
                    
                    if (Conf.HideGunStatus)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowUseableGunStatus);
                    
                    if (Conf.HideStatusIcon)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
                    
                    if (Conf.HideVehicleStatus)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowVehicleStatus);
                    
                    if (Conf.HideInteractWithEnemy)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowInteractWithEnemy);
                    
                }
            }
            catch (Exception e)
            {
                Logger.LogWarning($"[{Name}] Error: " + e);
            }
        }
    }
}