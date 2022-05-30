using System.Collections.Generic;
using RFVanillaUIManager.EventListeners;
using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;

namespace RFVanillaUIManager.Commands
{
    public class ApplyUICommand: IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;
        public string Name => "applyui";
        public string Help => "";
        public string Syntax => "";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string> {"applyui"};
        
        public void Execute(IRocketPlayer caller, string[] command)
        {
            foreach (var steamPlayer in Provider.clients)
                PlayerEvent.OnConnected(UnturnedPlayer.FromSteamPlayer(steamPlayer));
        }
    }
}