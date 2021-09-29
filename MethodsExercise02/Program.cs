using System;

namespace MethodsExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
        int x = 9, y = 3;

        Console.WriteLine(Add(x, y));
        Console.WriteLine(Subtract(x, y));
        Console.WriteLine(Multiply(x, y));
        Console.WriteLine(Divide(x, y));
        Console.WriteLine(Modulus(x, y));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
