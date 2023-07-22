using Calculator.Operations.Interfaces;
using Calculator.Operations.MathOperations;
using System;

namespace Calculator.Operations
{
    public class Calculadora
    {
        private readonly ISum _sum = new Addition();
        private readonly ISubstraction _substraction = new Substraction();
        private readonly IMultiplication _multiplication = new Multiplication();
        private readonly IDivision _divide = new Division();
        private readonly IExponentiation _exponentiation = new Exponentiation();


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
                        _sum.Sum(number1, number2);
                        break;
                    case "2":
                        _substraction.Substract(number1, number2);
                        break;
                    case "3":
                        _multiplication.Multiply(number1, number2);
                        break;
                    case "4":
                        _divide.FindTheDivision(number1, number2);
                        break;
                    case "5":
                        _divide.GetTheRestOfDivision(number1, number2);
                        break;
                    case "6":
                        _exponentiation.GetTheResultOfExponentiation(number1, number2);
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
