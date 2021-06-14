using System;

namespace CollectionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("Int Number was: " + GetIntNumberFromUser());
            Console.WriteLine("Double Number was: " + GetDoubleNumberFromUser());
            
        }// end of Main method

        static int GetIntNumberFromUser()
        {
            int number = 0;
            bool wasNotNumber = true;

            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    wasNotNumber = false;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("must enter something.");
                }
                catch (FormatException exceptionVarible)
                {
                    Console.WriteLine("was unable to read your number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number was too big.");
                }

            } while (wasNotNumber);


            return number;
        }

        static double GetDoubleNumberFromUser()
        {
            double number = 0;
            bool wasNotNumber = true;

            do
            {
                try
                {
                    //number = double.Parse(Console.ReadLine());
                    number = Convert.ToDouble(Console.ReadLine());
                    wasNotNumber = false;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("must enter something.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("was unable to read your number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number was too big.");
                }

            } while (wasNotNumber);


            return number;
        }

    }
}
