using System;

namespace CalculatorDP
{
    class Program
    {   /// <summary>
        /// Command Design Pattern
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("My Calculator using Dessign Patters!");
            User user = new User();
            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            // Undo 4 commands
            user.Undo(4);
            // Redo 3 commands
            user.Redo(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}
