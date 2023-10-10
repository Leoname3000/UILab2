using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static int[] randomInit(int length)
        {
            var result = new int[length];
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next();
            }
            return result;
        }

        static int[] sumEqualLength(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length) return new int[0];
            var result = new int[array1.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
        }

        static void multArray(ref int[] array, int mult)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= mult;
            }
        }

        static int[] sameElements(int[] array1, int[] array2)
        {
            var result = new int[0];
            foreach (var i in array1)
            {
                if (array2.Contains(i))
                {
                    result = result.Append(i).ToArray();
                }
            }
            return result;
        }

        static void printArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Empty array");
                return;
            }

            string result = "";
            foreach (var a in array)
            {
                result += $"{a} ";
            }
            Console.WriteLine(result);
        }

        static void sortByLower(ref int[] array)
        {
            // Using insertion sort
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] < array[j])
                    {
                        var current = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = current;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static int minArray(int[] array)
        {
            int min = Int32.MaxValue;
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        static int maxArray(int[] array)
        {
            int max = Int32.MinValue;
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static double averageArray(int[] array)
        {
            int sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }
            return (double)sum / array.Length;
        }

        static void Main(string[] args)
        {
            printArray(randomInit(5));

            printArray(sumEqualLength(new int[] { 1, 2, 3, 4, 5 }, new int[] { 10, 20, 30, 40, 50 }));
            printArray(sumEqualLength(new int[] { 1, 2 }, new int[] { 10, 20, 30 }));

            var array1 = new int[] { 1, 2, 3, 4, 5 };
            multArray(ref array1, 3);
            printArray(array1);

            printArray(sameElements(new int[] { 0, 2, 4, 6, 8 }, new int[] { 1, 2, 3, 4, 5, 6 }));
            printArray(sameElements(new int[] { 0, 2, 4 }, new int[] { 1, 3, 5, 7 }));

            var array2 = new int[] { 2, 3, 4, 5, 6, 7 };
            sortByLower(ref array2);
            printArray(array2);

            Console.WriteLine($"Min: {minArray(array2)}, max: {maxArray(array2)}, average: {averageArray(array2)}");
        }
    }
}
