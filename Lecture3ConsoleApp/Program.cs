using System;

namespace Lecture3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //An integer from -2,147,483,648 to +2,147,483,647
            int intNumber1 = 2147483647;
            int intNumber2 = -2147483647;

            //0 to 4,294,967,295
            uint uIntNumber = 30;

            double doubleNumber3 = 10.3;
            double doubleNumber4 = 10.3;

            //A positive integer value from 0 - 255;
            byte byteNumber = 255;

            //Inter value from -128 to 127
            sbyte sbyteNumber = -128;

            //An integer from -32,768 to + 32,767
            short shortNumber = -32768;

            long longNumber = 30;
            ulong uLongNumber = 30;

            float floatNumber = 30.4f;

            decimal decimalNumber = 20.4m;

            char charData = 'd';
            bool booleanData = true;

            /*
            double distance = 28.75;
            double speed = 75;
            double sales = 6500.0m;
            */

            /*
            decimal balance = 9280.7m;
            decimal price = 50;
            decimal sales = 6500.0;
            */

            //Console.WriteLine(intNumber1 + intNumber2);

            /*
            Console.WriteLine(10 - 5);
            Console.WriteLine(5 - 10);
            Console.WriteLine(10 * 5);
            Console.WriteLine(10 / 5);
            Console.WriteLine(1/2);
            Console.WriteLine(1m / 2m);
            Console.WriteLine(10 % 2);
            */

            /*
            Console.WriteLine(5 + 2 * 4);
            Console.WriteLine(10 / 2 - 3);

            Console.WriteLine((5 + 2) * 4);
            Console.WriteLine((6 - 3) * (2 + 7) / 3);
            */

            int x = 3;

            /*
            Console.WriteLine(++x); //x = 4
            Console.WriteLine(x++); //x = 4
            Console.WriteLine(x); //x =5
            */

            /*
            Console.WriteLine(x = x + 1);
            x += 1;
            ++x;
            */

            double grade = 93;
            int letter = 'C';
            char charLetter = (char)67;

            double a = 95.0;
            int b = 60;
            int c = 30;

            double average = (a + b + c) / 3;

            Console.WriteLine(letter);
            Console.WriteLine(grade.GetType());
            Console.WriteLine(letter.GetType());
            Console.WriteLine(charLetter.GetType());
            Console.WriteLine(charLetter);

            Console.WriteLine(average);

        }
    }
}
