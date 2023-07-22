using Calculator.Operations.MathOperations;
using System;

namespace Calculator.Operations
{
    public class MathOperation : IMathOperation
    {
        private readonly Sum _sum = new Sum();
        private readonly Substraction _substraction = new Substraction();
        private readonly Multiply _multiply = new Multiply();
        private readonly Division _divide = new Division();
        private readonly Exponentiation _exponentiation = new Exponentiation();
        
        public void FindTheSum(int number1, int number2)
        {
            _sum.FindTheSum(number1, number2);
        }
        public void FindTheDifference(int number1, int number2)
        {
            _substraction.FindTheDifference(number1, number2);
        }

        public void FindTheMultiplication(int number1, int number2)
        {
            _multiply.FindTheMultiplication(number1, number2);
        }

        public void FindTheDivision(int number1, int number2)
        {
            _divide.FindTheDivision(number1, number2); 
        }

        public void GetTheRestOfDivision(int number1, int number2)
        {
            _divide.GetTheRestOfDivision(number1, number2);
        }

        public void GetTheResultOfExponentiation(int number1, int number2)
        {
            _exponentiation.GetTheResultOfExponentiation(number1,number2);
        }
    }
}
