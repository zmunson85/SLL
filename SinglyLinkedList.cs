using System;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList() 
        {
            // your code here
            Head=null;
        }
        // SLL methods go here. As a starter, we will show you how to add a node to the list.
        public void Add(int value) 
        {
            SllNode newNode = new SllNode(value);
            if(Head == null) 
            {
                Head = newNode;
            } 
            else
            {
                SllNode runner = Head;
                while(runner.Next != null) {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }    
        public void Remove()
        // public void Remove(int x)
        {
            if(Head != null)
            {
                SllNode runner=Head;
                //only one node at this point
                if (Head.Next == null)
                {
                    Head=null;
                }
                //more than one node now (next = newNode)
                else
                {
                    while (runner.Next.Next!=null)
                    {
                        runner=runner.Next;
                    }
                    runner.Next=null;
                }
            }
        }
        public void PrintVal()
        {
            SllNode runner = Head;
            if(runner!=null)
            {
            while(runner.Next!=null)
            {
                Console.WriteLine(runner.Value);
                runner=runner.Next;
            }
            Console.WriteLine(runner.Value);
            }
            else
            {
                Console.WriteLine("NOT A SllNODE");
            }
        }
        public SllNode Find(int i)
        {
            SllNode runner =Head;
            while(runner.Next!=null)
            {
                if (runner.Value==i)
                {
                    return runner;
                }
                runner=runner.Next;
            }
            Console.WriteLine("Not a True Value");
            return null;
        }
        public int Length()
        {
            int length=0;
            SllNode runner=Head;
            while (runner.Next!=null)
            {
                runner=runner.Next;
                length++;
            }
            return length;
        }
        public void Remove(int n)
        {
            if(Head != null)
            {
                SllNode runner=Head;
                int index=0;
                //if out of bounds
                if (n>this.Length())
                {
                    Console.WriteLine("Out OF Bounds Sucka!");
                    return;
                }
                else if (n==0)
                {
                    Head=Head.Next;
                    runner=null;
                }
                //Multi node list
                else
                {
                    while (index+1!=n)
                    {
                        runner=runner.Next;
                        index++;
                    }
                    runner.Next=runner.Next.Next;
                }
            }


        }
    }
}