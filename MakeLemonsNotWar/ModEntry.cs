using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Objects;
using Microsoft.Xna.Framework;

namespace MakeLemonsNotWar
{
    internal sealed class ModEntry : Mod
    {
        /**********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            // event += method to call
            helper.Events.GameLoop.DayStarted += this.OnDayStarted;
        }

        /// <summary>The method called after a new day starts.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnDayStarted(object? sender, DayStartedEventArgs e)
        {
            this.Monitor.Log("A new day dawns!", LogLevel.Info);

            // Get the player
            Farmer player = Game1.player;

            // Create a position for the melon seed (use player's position as an example)
            Vector2 position = player.Position;

            // Create a new melon seed object
            StardewValley.Object melonSeed = new StardewValley.Object(position, "Melon Seeds", false);

            // Add the melon seed to the player's inventory
            player.addItemToInventory(melonSeed);

            // Notify the player about receiving the melon seed
            Game1.showGlobalMessage("You received a melon seed!");

            /*            This method is called when a new day starts in the game.
            It logs a message to the mod console using this.Monitor.Log.
            It gets the player instance using Game1.player.
            It creates a Vector2 position using the player's current position.
            It creates a new StardewValley.Object representing a melon seed at the specified position, with the name "Melon Seeds" and specifying that it's not a placeable furniture item (hence false).
            It adds the melon seed object to the player's inventory using player.addItemToInventory.
            Finally, it displays a global message to notify the player about receiving the melon seed using Game1.showGlobalMessage.*/
        }
    }
}
