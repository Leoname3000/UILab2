using System;

namespace Task2
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
            var array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(arrStr(array));

            int arrayHalf = array.Length / 2;
            Array.Resize(ref array, array.Length + arrayHalf);
            Array.Copy(array, 0, array, arrayHalf, array.Length - arrayHalf);
            Array.Copy(array, array.Length - arrayHalf, array, 0, arrayHalf);
            Array.Resize(ref array, array.Length - arrayHalf);

            Console.WriteLine(arrStr(array));
        }
    }
}
