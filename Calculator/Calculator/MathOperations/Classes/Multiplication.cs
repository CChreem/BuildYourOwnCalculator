using Calculator.Operations.Interfaces;
using System;

namespace Calculator.Operations.MathOperations
{
    public class Multiplication : IMultiplication
    {
        public void Multiply(int n1, int n2)
        {
            Console.WriteLine("Digite o número que deseja multiplicar: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite por quantas vezes deseja multiplicar {n1}: ");
            n2 = int.Parse(Console.ReadLine());

            int res = n1 * n2;

            Console.WriteLine($"\nA multiplicação de {n1} por {n2} é: {res}\n");
            Console.WriteLine("----------------------------------\n");

        }

    }
}
