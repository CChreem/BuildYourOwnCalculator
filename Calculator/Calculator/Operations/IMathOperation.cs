using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public interface IMathOperation
    {
        void FindTheSum(int number1, int number2);
        void FindTheDifference(int number1, int number2);
        void FindTheMultiplication(int number1, int number2);
        void FindTheDivision(int number1, int number2);
        void GetTheRestOfDivision(int number1, int number2);
        void GetTheResultOfExponentiation(int number1, int number2);

    }
}
