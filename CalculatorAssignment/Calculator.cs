using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAssignment
{
    public class Calculation
    {
        // Declare Delegate with double signauture
        public delegate double calcAppDelegate(double val1, double val2);

        // Declaring reference to delegate
        public calcAppDelegate calcAppObj;

        //Calculation Methods

        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Substract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Division(double x, double y)
        {
            return x / y;
        }
        public double Log(double x)
        {
            return Math.Log(x);
        }
        public double SqrRoot(double x)
        {
            return Math.Sqrt(x);
        }
        public double OneByX(double x)
        {
            return 1 / x;
        }

        internal double Calculator(cEnum operation, double value1, double value2)
        {
            switch (operation)
            {
                case cEnum.Addition:
                    calcAppObj = new calcAppDelegate(Add);
                    break;
                case cEnum.Subtraction:
                    calcAppObj = new calcAppDelegate(Substract);
                    break;
                case cEnum.Multiply:
                    calcAppObj = new calcAppDelegate(Multiply);
                    break;

                case cEnum.Divide:
                    calcAppObj = new calcAppDelegate(Division);
                    break;
            }
            return calcAppObj(value1, value2);
        }

        internal double Calculator(object aDD, double operand1, double operand2)
        {
            throw new NotImplementedException();
        }
        // Defining enum types for switch case
        public enum cEnum
        {
            Addition, Subtraction, Multiply, Divide, Log, Root, OnebyX
        }
    }


}
