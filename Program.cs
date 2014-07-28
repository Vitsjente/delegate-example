using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_example
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mathCalculations = new MathCalculations();

            Console.WriteLine("Multi delegate");
            mathCalculations.Calculations(10, 5);

            Console.WriteLine("");
            Console.WriteLine("Single delegate");
            mathCalculations.MultiplyCalculation(10, 3);
            Console.ReadLine();


        }
    }
}
