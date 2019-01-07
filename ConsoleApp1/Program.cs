using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Console.ReadKey();
        }

        //Question 1
        static int listCheck(int[] list, int val)
        {
            int count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == val)
                    count++;
            }
            return val * count;
        }

        static void Problem1()
        {
            int[] list = new int[] { 6, 4, 4, 1, 3 };
            Console.WriteLine(listCheck(list, 4));
        }

        static string LeapYearCheck(string userInput)
        {
            int year = Int32.Parse(userInput);
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return year + " is a leap year";
            }
            else
            {
                return year + " is not a leap year";
            }
        }

        static void Problem2()
        {
            Console.Write("Enter a year in YYYY format: ");
            string Year = Console.ReadLine();
            Console.WriteLine(LeapYearCheck(Year));
        }

        //Question 3
        static String SeqCheck(int[] list)
        {
            int sum = 0;
            int product = 1;
            String output = "";
            foreach (int i in list)
            {
                sum += i;
                product *= i;

                if (sum == product)
                {
                    output = "true";
                }
                else { output = "false"; }
            }
            return output;
        }


        static void Problem3()
        {
            int[] list = new int[] { 1, 2, 3 };
            Console.WriteLine(SeqCheck(list));
        }


        static void Problem4()
        {
            int[,] multiArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int rows = multiArray.GetLength(0);

            int[] rowSums = new int[rows];
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    sum += multiArray[i, j];
                }
                rowSums[i] = sum;
                sum = 0;
            }
            Console.WriteLine("{{ {0} }}", string.Join(", ", rowSums));

        }
    }
}
