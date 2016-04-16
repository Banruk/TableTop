using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTop
{
    /// <summary>
    /// I haven't decided where this data should reside in the code, so I made this class
    /// to hold it until a future date.
    /// </summary>
    class MagicalData
    {
        /// <summary>
        /// A list of the different chat mode options.
        /// In Game: You're character is talking
        /// Out of Game: You're talking as yourself, not your character
        /// Action Description: Trying to describe the action that just happened.
        /// </summary>
        static public String[] chat_type = { "In Game", "Out of Game", "Action Description" };
    }
}
