using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Models
{
    /// <summary>
    /// Class SnakeCell.
    /// Implements the <see cref="SnakesAndLadder.Models.Cell" />
    /// </summary>
    /// <seealso cref="SnakesAndLadder.Models.Cell" />
    public class SnakeCell : Cell
    {
        /// <summary>
        /// Gets or sets the penalty cell.
        /// </summary>
        /// <value>The penalty cell.</value>
        public int PenaltyCell { get; set; }
    }
}