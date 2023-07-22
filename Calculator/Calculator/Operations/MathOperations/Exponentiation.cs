using Calculator.Operations.Interfaces;
using System;

namespace Calculator.Operations.MathOperations
{
    public class Exponentiation : IExponentiation
    {
        public void GetTheResultOfExponentiation(int n1, int n2)
        {
            Console.WriteLine("Digite o valor da base: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do expoente: ");
            n2 = int.Parse(Console.ReadLine());

            var res = Math.Pow(n1, n2);

            Console.WriteLine($"\nO resultado de {n1} elevado a {n2} é: {res}\n");
            Console.WriteLine("----------------------------------\n");
        }
    }
}
