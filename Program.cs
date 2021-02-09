using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Linked List are Ideal for creating a que for say a playlist.
            SinglyLinkedList list = new SinglyLinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            // find (2)---this will print the value for val in list--(2)
            list.PrintVal();
            // remove- similar to arrays we can specify the index to remove as well

            list.Remove();//the last item in the list
            

            list.PrintVal();//this should print All Node values.... 1,2,3,4,5 except the 0 index which is one.
            //expeted output should be 2,3,4,5 on the last print line.
        }
    }
}