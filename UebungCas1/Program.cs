using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungCas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();

            BasicCalc Calculator = new BasicCalc();
            int resultat = Calculator.add(1, 5);

            Console.WriteLine("Das Resultat ist = " + resultat);
        }
    }
}
