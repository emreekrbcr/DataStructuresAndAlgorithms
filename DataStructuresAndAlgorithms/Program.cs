using System;
using DataStructuresAndAlgorithms.DataStructures.LinkedList;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> deneme = new SinglyLinkedList<int>();
            deneme.AddLast(5);
            deneme.AddLast(10);
            deneme.AddLast(7);
            //deneme.AddLast(-1);
            //deneme.AddLast(125);
            //deneme.AddLast("ankara");
            //deneme.AddLast("izmir");
            //deneme.AddLast("aydın");
            //deneme.AddLast("trabzon");
            //deneme.AddLast("Antalya");
            //deneme.AddLast("çankıRı");

            //Console.WriteLine(deneme.ToString());

            deneme.SortList();

            Console.WriteLine(deneme.ToString());

            //deneme.AddInSorted("erzincan");

            deneme.AddInSorted(-9);
            deneme.AddInSorted(5);
            deneme.AddInSorted(-3);
            deneme.AddInSorted(5);
            deneme.AddInSorted(6);
            Console.WriteLine(deneme.ToString());

            Console.Read();
        }
    }
}
