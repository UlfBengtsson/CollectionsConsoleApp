using System;

namespace CollectionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("Int Number was: " + GetIntNumberFromUser());
            //Console.WriteLine("Double Number was: " + GetDoubleNumberFromUser());

            MultiTable();
            
        }// end of Main method

        static void MultiTable()
        {
            // GetLength                    0  1
            int[,] multi_10_table = new int[10,5];// index for each 0,1,2,3,4,5,6,7,8,9

            for (int y = 0; y < multi_10_table.GetLength(0); y++)
            {

                for (int x = 0; x < multi_10_table.GetLength(1); x++)
                {
                    multi_10_table[y, x] = (y + 1) * (x + 1);
                }

            }

            for (int y = 0; y < multi_10_table.GetLength(0); y++)
            {

                for (int x = 0; x < multi_10_table.GetLength(1); x++)
                {
                    Console.Write(multi_10_table[y, x] + "\t");
                }
                Console.WriteLine();
            }
            /*
            foreach (int number in multi_10_table)
            {
                Console.Write(number + "\t");
            }
            */
        }

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
