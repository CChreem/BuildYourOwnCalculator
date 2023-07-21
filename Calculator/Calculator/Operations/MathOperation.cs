using Calculator.Operations.MathOperations;
using System;

namespace Calculator.Operations
{
    public class MathOperation : IMathOperation
    {
        private readonly Sum _sum;
        private readonly Substraction _substraction;
        private readonly Multiply _multiply;
        private readonly Division _divide;
        private readonly Exponentiation _exponentiation;
        
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
