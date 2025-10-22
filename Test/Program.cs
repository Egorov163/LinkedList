using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();

            var rnd = new Random();
            var startItems = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }

            timer.Start();
            var heap = new Heap(startItems);
            timer.Stop();
            Console.WriteLine("Первоначальная инициализация" + timer.Elapsed);

            timer.Restart();
            for (int i = 0; i < 10; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine("Второе добавление элементов" + timer.Elapsed);

            timer.Restart();
            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Вывод элементов" + timer.Elapsed);
        }
    }
}
