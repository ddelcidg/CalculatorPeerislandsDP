using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDP
{
    /// <summary>
    /// The 'Invoker' class
    /// knows how to perform the operations associated with carrying out the request.
    /// </summary>
    public class User
    {
        // Initializers
        Calculator calculator = new Calculator();
        List<Command> commands = new List<Command>();
        int current = 0;
        /// <summary>
        /// Redo operations commands
        /// </summary>
        /// <param name="levels"> Number of levels to Redo</param>
        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    Command command = commands[current++];
                    command.Execute();
                }
            }
        }
        /// <summary>
        /// Undo operations commands
        /// </summary>
        /// <param name="levels"> Number of levels to Undo</param>
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current] as Command;
                    command.UnExecute();
                }
            }
        }
        /// <summary>
        /// Create command operations and execute it receiving the corresponding parameters
        /// </summary>
        /// <param name="operator">arithmetic operation</param>
        /// <param name="operand">Values for perform the operation</param>
        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();
            // Add command to undo list
            commands.Add(command);
            current++;
        }
    }
}

