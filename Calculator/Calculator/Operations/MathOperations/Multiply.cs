using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations.MathOperations
{
    public class Multiply
    {
        public void FindTheMultiplication(int n1, int n2)
        {
            Console.WriteLine("Digite o npumero que deseja multiplicar: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite por quantas vezes deseja multiplicar {n1}: ");
            n2 = int.Parse(Console.ReadLine());

            int res = n1 * n2;

            Console.WriteLine($"A multiplicação de {n1} por {n2} é: {res}\n");
        }

    }
}
