using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDP
{
    class FunctionNode : EvalNode
    {
        EvalNode lhs = new ValueNode(decimal.Zero);
        EvalNode rhs = new ValueNode(decimal.Zero);
        string op = "+";

        public string Op
        {
            get { return op; }
            set
            {
                op = value;
            }
        }

        internal EvalNode Rhs
        {
            get { return rhs; }
            set
            {
                rhs = value;
            }
        }

        internal EvalNode Lhs
        {
            get { return lhs; }
            set
            {
                lhs = value;
            }
        }
        /// <summary>
        /// Evaluator of operations.
        /// It adds the result of all this operations en a variable result
        /// </summary>
        /// <returns></returns>
        public override decimal Evaluate()
        {
            decimal result = decimal.Zero;

            switch (op)
            {
                case "+":
                    result = lhs.Evaluate() + rhs.Evaluate();
                    break;

                case "-":
                    result = lhs.Evaluate() - rhs.Evaluate();
                    break;

                case "*":
                    result = lhs.Evaluate() * rhs.Evaluate();
                    break;

                case "/":
                    result = lhs.Evaluate() / rhs.Evaluate();
                    break;

                case "%":
                    result = lhs.Evaluate() % rhs.Evaluate();
                    break;

                case "^":
                    double x = Convert.ToDouble(lhs.Evaluate());
                    double y = Convert.ToDouble(rhs.Evaluate());

                    result = Convert.ToDecimal(Math.Pow(x, y));
                    break;

                case "!":
                    result = Factorial(lhs.Evaluate());
                    break;
            }

            return result;
        }

        private decimal Factorial(decimal factor)
        {
            if (factor < 1)
                return 1;

            return factor * Factorial(factor - 1);
        }

        public override string ToString()
        {
            return "(" + lhs.ToString() + " " + op + " " + rhs.ToString() + ")";
        }
    }
}
