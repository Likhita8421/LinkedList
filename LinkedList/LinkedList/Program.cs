// See https://aka.ms/new-console-template for more information

using System;
namespace LinkedList
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedListData list = new LinkedListData();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.DisPlay();
            //int a = list.Search(30);
            //Console.WriteLine("index position of element 30 is: " + a);
            //list.InsertAtPerticularPosition(a + 1, 40);
            //list.DisPlay();
            //list.RemoveFirstNode(56);
            //list.RemoveLastNode(70);
            //list.DisPlay();
            //list.AddMethod(30);
            //list.AddMethod(56);
            //list.DisPlay();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.DisPlay();




        }
    }
}
