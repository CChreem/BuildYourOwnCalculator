using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations.MathOperations
{
    public class Substraction
    {
        public void FindTheDifference(int n1, int n2)
        {
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            int res = n1 - n2;

            Console.WriteLine($"A subtração de {n1} e {n2} é: {res}\n");
        }
    }
}
