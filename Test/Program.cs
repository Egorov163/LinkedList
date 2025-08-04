using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("Добавили 5 элементов.");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.Delete(3);
            Console.WriteLine("\nУдалили 3 элемент.");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.AppendHead(10);
            Console.WriteLine("\nДобавили 10 элемент в начало.");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nДобавили 20 элемент после 4.");
            list.InsertAfter(4, 20);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
