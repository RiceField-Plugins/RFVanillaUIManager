using Rocket.API;

namespace RFVanillaUIManager
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public bool RevertOnUnload;
        public string Permission;
        public bool HideFoodBar;
        public bool HideHealthBar;
        public bool HideOxygenBar;
        public bool HideStaminaBar;
        public bool HideVirusBar;
        public bool HideWaterBar;
        public bool HideDeathMenu;
        public bool HideStatusIcon;
        public bool HideVehicleStatus;
        public bool HideInteractWithEnemy;
        public bool HideGunStatus;
        
        public void LoadDefaults()
        {
            Enabled = true;
            RevertOnUnload = true;
            Permission = "ui_disable";
            HideFoodBar = true;
            HideHealthBar = true;
            HideOxygenBar = true;
            HideStaminaBar = true;
            HideVirusBar = true;
            HideWaterBar = true;
            HideDeathMenu = false;
            HideStatusIcon = false;
            HideVehicleStatus = false;
            HideInteractWithEnemy = false;
            HideGunStatus = true;
        }
    }
}