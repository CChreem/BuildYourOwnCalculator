using Calculator.Operations.Interfaces;
using System;

namespace Calculator.Operations.MathOperations
{
    public class Division : IDivision
    {
        public void FindTheDivision(int n1, int n2)
        {
            Console.WriteLine("Digite o número que quer dividir: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite por quanto quer dividir {n1}: ");
            n2 = int.Parse(Console.ReadLine());

            if (n2 != 0)
            {
                int res = n1 / n2;
                Console.WriteLine($"\nA divisão de {n1} por {n2} é: {res}\n");
                Console.WriteLine("----------------------------------\n");

            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero\n");
            }
        }

        public void GetTheRestOfDivision(int n1, int n2)
        {
            Console.WriteLine("Digite o número que quer dividir: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite por quanto quer dividir {n1}: ");
            n2 = int.Parse(Console.ReadLine());

            if (n2 != 0)
            {
                int res = n1 % n2;

                Console.WriteLine($"O resto da divisão de {n1} por {n2} é: {res}\n");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero\n");

            }
        }
    }
}
