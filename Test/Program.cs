using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new SuperHashTable<Person>(100);
            var aleksandr = new Person() { Name = "Aleksandr", Age = 23, Gender = "M" };
            var oleg = new Person() { Name = "Oleg", Age = 42, Gender = "M" };
            superHashTable.Add(new Person() { Name = "Alice", Age = 18, Gender = "W" });
            superHashTable.Add(aleksandr);
            superHashTable.Add(new Person() { Name = "Katya", Age = 24, Gender = "W" });

            Console.WriteLine(superHashTable.Search(aleksandr));
            Console.WriteLine(superHashTable.Search(oleg));


            //var hashTable = new HashTable<int, string>(100);
            //hashTable.Add(5, "q");
            //hashTable.Add(18, "w");
            //hashTable.Add(777, "e");

            //Console.WriteLine(hashTable.Search(6, "q"));
            //Console.WriteLine(hashTable.Search(18, "w"));


            //var badHashTable = new BadHashTable<int>(100);
            //badHashTable.Add(5);
            //badHashTable.Add(18);
            //badHashTable.Add(777);

            //Console.WriteLine(badHashTable.Search(6));
            //Console.WriteLine(badHashTable.Search(18));
        }
    }
}
