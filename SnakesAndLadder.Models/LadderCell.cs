using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadder.Models
{
    /// <summary>
    /// Class LadderCell.
    /// Implements the <see cref="SnakesAndLadder.Models.Cell" />
    /// </summary>
    /// <seealso cref="SnakesAndLadder.Models.Cell" />
    public class LadderCell : Cell
    {
        /// <summary>
        /// Gets or sets the advantage cell.
        /// </summary>
        /// <value>The advantage cell.</value>
        public int AdvantageCell { get; set; }
    }
}