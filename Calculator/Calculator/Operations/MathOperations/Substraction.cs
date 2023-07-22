using Calculator.Operations.Interfaces;
using System;

namespace Calculator.Operations.MathOperations
{
    public class Substraction : ISubstraction
    {
        public void Substract(int n1, int n2)
        {
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            int res = n1 - n2;

            Console.WriteLine($"\nA subtração de {n1} e {n2} é: {res}\n");
            Console.WriteLine("----------------------------------\n");

        }
    }
}
