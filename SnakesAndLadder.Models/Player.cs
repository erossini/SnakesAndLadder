using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Models
{
    /// <summary>
    /// Class Player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the player number.
        /// </summary>
        /// <value>The player number.</value>
        public int PlayerNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        /// <value>The name of the player.</value>
        public string PlayerName { get; set; }

        /// <summary>
        /// Gets or sets the current cell position.
        /// </summary>
        /// <value>The current cell position.</value>
        public int CurrentCellPosition { get; set; }
    }
}
