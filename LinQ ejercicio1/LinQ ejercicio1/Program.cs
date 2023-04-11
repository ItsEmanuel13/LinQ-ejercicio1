using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var valoresLQ = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sumaLQ = valoresLQ.Sum();
            Console.WriteLine(sumaLQ);

            //Ejercicio2
            var valoresLQ2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valoresParesLQ2 = valoresLQ2.Where(valor => valor % 2 == 0).ToList();
            var sumaLQ2 = valoresParesLQ2.Sum();
            Console.WriteLine(sumaLQ2);

            //Ejercicio3
            var valoresLQ3 = new List<int>() { 3, 6, 9, 7, 4, 1, 2, 5, 8 };
            var valoersOrdenados = valoresLQ3.OrderByDescending(x => x);
            foreach (var valorOrdenado in valoresLQ3)
            {
                Console.WriteLine(valorOrdenado);
            }
            Console.WriteLine("");

            //Ejercicio4
            var valoresLQ4 = new List<int>() { 3, 6, 9, 7, 4, 1, 2, 5, 8 };
            var valoresOrdenados2 = valoresLQ4.OrderBy(x => x);
            foreach (var valorOredenado in valoresLQ4)
            {
                Console.WriteLine(valorOredenado);
            }
            Console.WriteLine("");

            

        }
    }
}
