using System;
using System.Collections.Generic;
using System.Text;
using static CalculatorDP.CalculatorCommand;
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
        /// <summary>
        /// Create command operations and execute it receiving the corresponding parameters
        /// </summary>
        /// <param name="operator">arithmetic operation</param>
        /// <param name="operand">Values for perform the operation</param>
        public void Compute(string equation)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(equation);
            command.Execute(equation);

 
        }


    }
}

