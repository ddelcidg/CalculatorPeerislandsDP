using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDP
{
    /// <summary>
    /// The 'Command' abstract class
    /// This structural code demonstrates the Command pattern which stores requests as objects allowing clients to execute or playback the requests.
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
