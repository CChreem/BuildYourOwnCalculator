using System;

namespace Calculator.Operations.MathOperations
{
    public class Sum
    {
        public void FindTheSum(int n1, int n2)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            int res = n1 + n2;

            Console.WriteLine($"A soma de {n1} e {n2} é: {res}\n");

            Console.ReadKey();
        }
    }
}
