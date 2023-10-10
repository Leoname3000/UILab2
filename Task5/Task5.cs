using System;

namespace Task5
{
    class Program
    {
        const int SIDE = 10;
        const int MIN = 1;
        const int MAX = 9;

        static int[] multMatrix(int[] a, int[] b, int side)
        {
            var result = new int[side * side];
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    for (int k = 0; k < side; k++)
                    {
                        result[side * i + j] += a[side * i + k] * b[side * k + j];
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            var a = new int[SIDE * SIDE];
            var b = new int[SIDE * SIDE];
            Random random = new Random();
            string astr = "";
            string bstr = "";
            for (int i = 0; i < SIDE * SIDE; i++)
            {
                a[i] = random.Next(MIN, MAX);
                b[i] = random.Next(MIN, MAX);
                astr += $"{a[i]} ";
                bstr += $"{b[i]} ";
            }

            Console.WriteLine(astr);
            Console.WriteLine(bstr);
            Console.WriteLine();

            var result = multMatrix(a, b, SIDE);
            string row = "";
            for (int i = 0; i < result.Length; i++)
            {
                row += $"{result[i]} ";
            }
            Console.WriteLine(row);
        }
    }
}
