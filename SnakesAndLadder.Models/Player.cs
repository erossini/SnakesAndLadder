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
        public int CurrentCellPosition { get; set; } = 1;

        /// <summary>
        /// Gets or sets is the player is the winner
        /// </summary>
        /// <value>True if the player is the winner</value>
        public bool IsTheWinner { get; set; } = false;

        /// <summary>
        /// Gets or sets the first dice to define the order
        /// </summary>
        /// <value>Value of the first dice</value>
        public int FirstDice { get; set; } = 0;
    }
}
