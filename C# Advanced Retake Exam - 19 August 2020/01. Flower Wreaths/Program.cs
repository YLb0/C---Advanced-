using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] n1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> zambaket = new Stack<int>(n);
            Queue<int> trendafilat = new Queue<int>(n1);

            int kurorat = 0;
            int sum = 0;
            int kurorat1 = 0;
            while (zambaket.Count > 0 && trendafilat.Count > 0)
            {
                if (zambaket.Peek() + trendafilat.Peek() == 15)
                {
                    kurorat++;
                    zambaket.Pop();
                    trendafilat.Dequeue();
                }
                else if (zambaket.Peek() + trendafilat.Peek() > 15)
                {
                    int zamb = zambaket.Pop() - 2;
                    zambaket.Push(zamb);
                }
                else if (zambaket.Peek() + trendafilat.Peek() < 15)
                {
                    sum += zambaket.Pop();
                    sum += trendafilat.Dequeue();
                }
            }
            if (sum >= 15)
            {
                kurorat1 = sum / 15;
            }
            int total = kurorat + kurorat1;
            if (total >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {total} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - total} wreaths more!");
            }
        }
    }
}
