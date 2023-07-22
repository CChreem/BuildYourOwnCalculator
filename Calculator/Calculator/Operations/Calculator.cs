using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class Calculadora
    {
        private readonly IMathOperation operations = new MathOperation();

        public void Operation()
        {
            int number1 = 0;
            int number2 = 0;
            bool OnOff = true;
            string mathOperation;

            while (OnOff)
            {
                Console.WriteLine("\tCALCULADORA");

                Console.WriteLine("Digite a operação que deseja realizar: " + "\n \"1\" Somar\n \"2\" Subtrair\n \"3\" Multiplicar\n \"4\" Dividir\n \"5\" Resto da Divisão\n \"6\" Potenciação\n \"0\" sair");
                mathOperation = Console.ReadLine();

                switch (mathOperation)
                {
                    case "1":
                        operations.FindTheSum(number1, number2);
                        break;
                    case "2":
                        operations.FindTheDifference(number1, number2);
                        break;
                    case "3":
                        operations.FindTheMultiplication(number1, number2);
                        break;
                    case "4":
                        operations.FindTheDivision(number1, number2);
                        break;
                    case "5":
                        operations.GetTheRestOfDivision(number1, number2);
                        break;
                    case "6":
                        operations.GetTheResultOfExponentiation(number1, number2);
                        break;
                    case "0":
                        OnOff = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida\n");
                        break;
                }
            }
        }
    }
}
