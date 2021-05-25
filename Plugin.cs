using System;
using RFVanillaUIDisabler.EventListeners;
using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Logger = Rocket.Core.Logging.Logger;

namespace RFVanillaUIDisabler
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Inst;
        public static Configuration Conf;

        protected override void Load()
        {
            Inst = this;
            Conf = Configuration.Instance;
            if (!Configuration.Instance.Enabled)
            {
                Logger.LogWarning($"[{Name}] Plugin: DISABLED");
                Unload();
                return;
            }

            U.Events.OnPlayerConnected += PlayerEvent.OnConnected;
            
            Logger.LogWarning($"[{Name}] Plugin loaded successfully!");
            Logger.LogWarning($"[{Name}] {Name} v1.0.0");
            Logger.LogWarning($"[{Name}] Made with 'rice' by RiceField Plugins!");
        }
        protected override void Unload()
        {
            if (Conf.RevertOnUnload)
                EnableVanillaUI();
            
            Inst = null;
            Conf = null;
            
            U.Events.OnPlayerConnected -= PlayerEvent.OnConnected;

            Logger.LogWarning($"[{Name}] Plugin unloaded successfully!");
        }
        public override TranslationList DefaultTranslations => new TranslationList
        {
            {"example_translation1", "[RFVanillaUIDisabler] Example Translation 1"},
        };

        private void EnableVanillaUI()
        {
            try
            {
                foreach (var steamPlayer in Provider.clients)
                {
                    var player = UnturnedPlayer.FromSteamPlayer(steamPlayer);
                    if (!player.HasPermission(Conf.Permission)) continue;
                    if (Conf.DisableFood)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
                    if (Conf.DisableHealth)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
                    if (Conf.DisableOxygen)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
                    if (Conf.DisableStamina)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
                    if (Conf.DisableVirus)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
                    if (Conf.DisableWater)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
                    if (Conf.DisableDeathMenu)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowDeathMenu);
                    if (Conf.DisableGunStatus)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowUseableGunStatus);
                    if (Conf.DisableStatusIcon)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
                    if (Conf.DisableVehicleStatus)
                        player.Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowVehicleStatus);
                    if (Conf.DisableInteractWithEnemy)
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