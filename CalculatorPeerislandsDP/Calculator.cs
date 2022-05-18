using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDP
{
    /// <summary>
    /// The 'Receiver' class
    /// knows how to perform the operations associated with carrying out the request.
    /// </summary>
    public class Calculator
    {
        int curr = 0;
        /// <summary>
        /// Method to perform the arithmetic operations
        /// </summary>
        /// <param name="operator">arithmetic operation</param>
        /// <param name="operand">Values for perform the operation</param>
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': curr += operand; break;
                case '-': curr -= operand; break;
                case '*': curr *= operand; break;
                case '/': curr /= operand; break;
            }
            Console.WriteLine(
                "Current value = {0,3} (following {1} {2})",
                curr, @operator, operand);
        }
    }
}
