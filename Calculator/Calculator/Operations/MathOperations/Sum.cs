using Calculator.Operations.Interfaces;
using System;

namespace Calculator.Operations.MathOperations
{
    public class Addition : ISum
    {
        public void Sum(int n1, int n2)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            int res = n1 + n2;

            Console.WriteLine($"\nA soma de {n1} e {n2} é: {res}");
            Console.WriteLine("----------------------------------\n");

        }
    }
}
