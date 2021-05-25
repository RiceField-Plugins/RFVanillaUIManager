using Rocket.API;

namespace RFVanillaUIDisabler
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public bool RevertOnUnload;
        public string Permission;
        public bool DisableFood;
        public bool DisableHealth;
        public bool DisableOxygen;
        public bool DisableStamina;
        public bool DisableVirus;
        public bool DisableWater;
        public bool DisableDeathMenu;
        public bool DisableStatusIcon;
        public bool DisableVehicleStatus;
        public bool DisableInteractWithEnemy;
        public bool DisableGunStatus;
        
        public void LoadDefaults()
        {
            Enabled = true;
            RevertOnUnload = true;
            Permission = "ui_disable";
            DisableFood = false;
            DisableHealth = false;
            DisableOxygen = false;
            DisableStamina = false;
            DisableVirus = false;
            DisableWater = false;
            DisableDeathMenu = false;
            DisableStatusIcon = false;
            DisableVehicleStatus = false;
            DisableInteractWithEnemy = false;
            DisableGunStatus = false;
        }
    }
}