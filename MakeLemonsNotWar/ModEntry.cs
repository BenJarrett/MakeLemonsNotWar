using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace MakeLemonsNotWar
{
    internal sealed class ModEntry : Mod
    {

        public override void Entry(IModHelper helper)
        {

            helper.Events.GameLoop.DayStarted += this.OnDayStarted;
        }


        private void OnDayStarted(object? sender, DayStartedEventArgs e)
        {
            this.Monitor.Log("A new day dawns!", LogLevel.Info);

            // Get the player
            Farmer player = Game1.player;

            // Add a melon seed to the player's inventory
            player.addItemToInventory(new Object(472, 1)); // 472 is the ID for Melon Seeds

            // Notify the player about receiving the melon seed
            Game1.showGlobalMessage("You received a melon seed!");
        }
    }
}
