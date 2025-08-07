using System;
using Test.Model;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Тест LinkedList

            //var list = new Model.LinkedList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //Console.WriteLine("Добавили 5 элементов.");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //list.Delete(3);
            //Console.WriteLine("\nУдалили 3 элемент.");

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //list.AppendHead(10);
            //Console.WriteLine("\nДобавили 10 элемент в начало.");

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\nДобавили 20 элемент после 4.");
            //list.InsertAfter(4, 20);
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Тест DuplexList
            //var duplexList = new DuplexLinkedList<int>();
            //duplexList.Add(1);
            //duplexList.Add(2);
            //duplexList.Add(3);
            //duplexList.Add(4);
            //duplexList.Add(5);

            //foreach (var item in duplexList)
            //{
            //    Console.WriteLine(item);
            //}

            //duplexList.Delete(3);

            //foreach (var item in duplexList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //var reverse = duplexList.Reverse();

            //foreach (var item in reverse)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region CircularLinked
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }

            circularList.Delete(3);
            Console.WriteLine();
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
