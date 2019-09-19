using System;



namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("PI is " + MathText.GetPi());
            int x = MathText.GetSquareOf(5);
            Console.WriteLine("square of  5 is " + x);

            MathText math = new MathText();
            math.value = 30;
            Console.WriteLine("value field of math varlable contains " + math.value);
            Console.WriteLine("square of 30 is " + math.GetSquare());
        }

        public class MathText
        {
            public int value;

            public int GetSquare()
            {


                return value * value;
            }
            public static int GetSquareOf(int x)
            {
                return x * x;
            }
            public static double GetPi()
            {
                return 3.1415926;
            }

        }
    }
}

