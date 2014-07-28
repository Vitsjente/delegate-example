using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_example
{
    public class MathCalculations
    {
        //Create delegate for all math calculation
        public delegate void Calculation(int i, int j);

        //Handle multiple delegate actions
        public Calculation Calculations;

        public Calculation MultiplyCalculation;

        public Calculation CalculationsMinusMultiply;

        //Create multiple 
        public MathCalculations()
        {
            Calculations = Add;
            Calculations += Multiply;
            Calculations += Divide;

            CalculationsMinusMultiply = Calculations - Multiply;

            MultiplyCalculation = Multiply;
        }

        /// <summary>
        /// Add two integers and write them to the screen
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void Add(int i, int j)
        {
            Console.WriteLine(String.Format("Add result {0}", i + j));
         }

        /// <summary>
        /// Multiply two integers and write them to the screen
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void Multiply(int i, int j)
        {
            Console.WriteLine(String.Format("Multiply result {0}", i * j));
        }

        /// <summary>
        /// Multiply two integers and write them to the screen
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void Divide(int i, int j)
        {
            if (j == 0)
                return;

            Console.WriteLine(String.Format("Divide result {0}", i / j));
        }

    }
}
