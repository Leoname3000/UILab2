using System;

namespace Task1
{
    class Program
    {
        static string arrStr(int[] array)
        {
            string result = "";
            foreach (var a in array)
            {
                result += $"{a} ";
            }
            return result;
        }

        static void Main(string[] args)
        {
            var copyFrom = new int[] { 1, 2, 3, 4, 5 };
            var copyTo = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            int K = 3;
            Console.WriteLine($"Copy from: {arrStr(copyFrom)}");
            Console.WriteLine($"Copy to: {arrStr(copyTo)}");

            Array.Resize(ref copyTo, copyTo.Length + copyFrom.Length);
            Array.Copy(copyTo, K, copyTo, K + copyFrom.Length, copyTo.Length - copyFrom.Length - K);
            Array.Copy(copyFrom, 0, copyTo, K, copyFrom.Length);

            Console.WriteLine($"Result: {arrStr(copyTo)}");
        }
    }
}
