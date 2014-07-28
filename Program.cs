using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_example
{
    public class Program
    {
        const string PRESS_ENTER_TO_SEE_MENU = "Press enter to see menu";

        public static void Main(string[] args)
        {
            var mathCalculations = new MathCalculations();
            ConsoleKeyInfo keyPress;

            DisplayMenu();

            do
            {
                keyPress = Console.ReadKey(false); // show the key as you read it

                Console.Clear();
                switch (keyPress.KeyChar.ToString())
                {
                    case "1":
                        mathCalculations.MultiplyCalculation(10, 3);
                        break;
                    case "2":
                        mathCalculations.Calculations(10, 3);
                        break;
                    case "3":
                        mathCalculations.CalculationsMinusMultiply(10, 3);
                        break;
                }

                Console.WriteLine(PRESS_ENTER_TO_SEE_MENU);
                if (keyPress.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    DisplayMenu();
                }


            } while (keyPress.Key != ConsoleKey.Escape);

        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Delegate test menu:");
            Console.WriteLine();
            Console.WriteLine("1. Only multiply");
            Console.WriteLine("2. Perform all calculations");
            Console.WriteLine("3. Perform all calculations minus multiply");
            Console.WriteLine("Press escape to exit");
        }
    }
}
