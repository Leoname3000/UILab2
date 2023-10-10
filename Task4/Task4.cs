using System;

namespace Task4
{
    class Program
    {
        static int findRowWithFreePlaces(int[][] info, int free)
        {
            for (int row = 0; row < info.Length; row++)
            {
                int found = 0;
                for (int place = 0; place < info[row].Length; place++)
                {
                    if (info[row][place] == 0)
                    {
                        found++;
                        if (found == free)
                        {
                            return row + 1;
                        }
                    }
                    else
                    {
                        found = 0;
                    }
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter matrix: ");
            var info = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                info[row] = Array.ConvertAll(input.Split(' '), int.Parse);
            }

            Console.WriteLine("Free places: ");
            int free = Convert.ToInt32(Console.ReadLine());

            int theRow = findRowWithFreePlaces(info, free);
            Console.WriteLine($"\nResult: {theRow}");
        }
    }
}
