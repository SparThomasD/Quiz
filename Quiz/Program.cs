using System;

namespace Quiz
{
    class Program
    {

        public static void main(string[] args)
        {
            System.Console.WriteLine("CIS 3025 Quiz Results:");
            System.Console.WriteLine();
            System.Console.WriteLine("Mystery 1: " + Mystery1());
            System.Console.WriteLine("Mystery 2: " + Mystery2(20));
            System.Console.WriteLine("Mystery 3: " + Mystery3("John", "Smith"));
            int num1 = 23;
            int num2 = 42;
            Mystery4(ref num1, ref num2);
            System.Console.WriteLine("Mystery 4: " + num1 + ", " + num2);
        }

        static int Mystery1()
        {
            int x = 30;
            return (int)Math.Round(Math.PI * x);
        }

        static int Mystery2(int num)
        {
            System.Random randy = new Random(num);
            for (int idx = 0; idx < num; idx++)
            {
                int x = randy.Next(idx, num);
            }
            return num;
        }

        static int Mystery3(string fn, string ln)
        {
            string fullname = fn + " " + ln;
            int combinedValue = 0;
            foreach (char c in fullname.ToCharArray())
            {
                combinedValue += c;
            }
            return combinedValue;
        }

        static int Mystery4(ref int x, ref int y)
        {
            int swap = x;
            y = x;
            x = swap;
            return x;
        }
    }
}
