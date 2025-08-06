using System;
using System.Collections.Generic;
using Test.Model;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var easyStack = new EasyStack<int>();

            //easyStack.Push(1);
            //easyStack.Push(2);
            //easyStack.Push(3);

            //var item = easyStack.Pop();
            //var item2 = easyStack.Peek();

            //Console.WriteLine(item);
            //Console.WriteLine(item2);

            //Stack<double> stack = new Stack<double>();

            //var linkedStack = new LinkedStack<int>();
            //linkedStack.Push(10);
            //linkedStack.Push(20);
            //linkedStack.Push(30);
            //linkedStack.Push(40);
            //linkedStack.Push(50);

            //Console.WriteLine(linkedStack.Peek());
            //Console.WriteLine(linkedStack.Pop());
            //Console.WriteLine(linkedStack.Pop());
            //Console.WriteLine(linkedStack.Peek());

            var arrayStack = new ArrayStack<int>(5);
            arrayStack.Push(10);
            arrayStack.Push(20);
            arrayStack.Push(30);
            arrayStack.Push(40);
            arrayStack.Push(50);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());;
        }
    }
}
