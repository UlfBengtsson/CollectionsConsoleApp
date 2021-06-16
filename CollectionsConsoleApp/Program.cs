using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsConsoleApp
{
    class Program
    {
        /*
            bool x = "Ulf" == "Ulf";//bad can give false possitives
            bool y = "Ulf".Equals("Ulf");//correct way
        */
        static void Main(string[] args)
        {
            //Console.WriteLine("Int Number was: " + GetIntNumberFromUser());
            //Console.WriteLine("Double Number was: " + GetDoubleNumberFromUser());
            //MultiTable();
            //WorkingWithList();
            //StringBuilderTest();
            //DictionaryThings();
            //RandomThings();

            


        }// end of Main method

        /// <summary>
        /// Primitive values like int/double are sent as copys 
        /// Objects are sent as a reference (will remember changes inside of them)
        /// </summary>
        static void PrimitiveVSObject() 
        {
            string test = "test";

            CanIModefieString(test);

            Console.WriteLine(test);

            StringBuilder test2 = new StringBuilder("test2");

            CanIModefieStringBuilder(test2);

            Console.WriteLine(test2);
        }

        static void CanIModefieStringBuilder(StringBuilder original)
        {
            original.Append("mod");
            //return original;
        }

        static void CanIModefieString(string original)
        {
            original = original + "mod";
            //return original;
        }

        static void RandomThings()
        {
            Random rng = new Random();//new Random(DateTime.Now.Millisecond);
            //Random rng2 = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 15; i++)
            {
                //Console.WriteLine(rng.Next());
                //Console.WriteLine(rng.Next(10)); // 0 to 9 max is exclusiv
                Console.WriteLine("Player 1: " + rng.Next(10,20)); // 10 to 19 max is exclusiv but min is inclusiv
                Console.WriteLine("Player 2: " + rng.Next(10,20)); // 10 to 19 max is exclusiv but min is inclusiv
            }

        }

        static void DictionaryThings()
        {
            Dictionary<int, string> willBankVault = new Dictionary<int, string>();

            willBankVault.Add(666, "The devil");
            
            willBankVault.Add(999, "The arch devil");

            foreach (KeyValuePair<int,string> item in willBankVault)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

        static void StringThings()
        {
            StringBuilder stringBuilderEx = new StringBuilder("test");

            string testString = stringBuilderEx.ToString();
            string testUpper = "Test";

            Console.WriteLine(testString);
            Console.WriteLine(testString[2]);
            Console.WriteLine(testString.ToUpper());
            Console.WriteLine("is not sensetiv to small big leter? " + testString.Equals(testUpper));
            Console.WriteLine("is not sensetiv to small big leter (using OrdinalIgnoreCase)? " + testString.Equals(testUpper, StringComparison.OrdinalIgnoreCase));
        }

        static void StringBuilderTest()
        {
            string resultString = "";

            DateTime stringStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                resultString = resultString + "*";
            }

            DateTime stringEnd = DateTime.Now;

            TimeSpan stringTime = stringEnd.Subtract(stringStart);

            //------------------------------------------------

            StringBuilder resultSB = new StringBuilder("");

            DateTime stringSBStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                resultSB = resultSB.Append("*");
            }

            DateTime stringSBEnd = DateTime.Now;

            TimeSpan sBTime = stringSBEnd.Subtract(stringSBStart);

            Console.WriteLine("String time: " + stringTime);
            Console.WriteLine("StringBuilder time: " + sBTime);

            //--------------------------------------

            
        }

        static void WorkingWithList()
        {
            List<string> firstNames = new List<string>();//new List<string>(3); start the list with Capacity of 3

            firstNames.Add("Ulf");

            Console.Write("Enter a first name that is not Ulf: ");
            firstNames.Add(Console.ReadLine());

            PrintList(firstNames, "first names");

            List<string> lastNames = new List<string> { "Andersson", "Bengtsson", "Svensson" };

            //lastNames.Add("Andersson");

            PrintList(lastNames, "last names");
            
            Console.WriteLine("Dose first names contain Ulf?: " + firstNames.Contains(firstNames[0]));//firstNames[0]) "Ulf"

            Console.WriteLine("List uses count to say how many are in the list: " + firstNames.Count);
            Console.WriteLine("List uses Capacity to say how many can be in the list before it expands: " + firstNames.Capacity);
        }

        static void PrintList(List<string> stringList, string nameOfList)
        {
            Console.WriteLine($"-------- {nameOfList} list ----------");
            foreach (string item in stringList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"-------- end of {nameOfList} list ----------\n");
        }

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
