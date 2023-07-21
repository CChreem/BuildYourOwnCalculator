using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations.MathOperations
{
    public class Exponentiation
    {
        public void GetTheResultOfExponentiation(double n1, int n2)
        {
            Console.WriteLine("Digite o valor da base: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do expoente: ");
            n2 = int.Parse(Console.ReadLine());

            var res = Math.Pow(n1, n2);

            Console.WriteLine($"O resultado de {n1} elevado a {n2} é: {res}\n");
        }
    }
}
