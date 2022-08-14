using System;
using static CalculatorDP.CalculatorCommand;

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
            string eq;
            Console.Write("Enter equation:  ");
            eq = Console.ReadLine();
            user.Compute(eq);

        }
    }
    class EvalNode
    {
        public virtual decimal Evaluate()
        {
            return decimal.Zero;
        }
    }

    class ValueNode : EvalNode
    {
        decimal value;

        public ValueNode(decimal v)
        {
            value = v;
        }

        public override decimal Evaluate()
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

}
