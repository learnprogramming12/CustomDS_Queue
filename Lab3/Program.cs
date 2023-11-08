using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Xiupeng Cui 1566716
/*
The underlying data structure of queue in the program is a double linked list. So the time complexity for
enqueue, dequeue, peek is O(1). It is not represented in the program.
*/
namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestingSystem system = new TestingSystem();
            system.Launch();
            //test double linked list.
            /*            Node<int> node1 = new Node<int>(1);
                        Node<int> node2 = new Node<int>(2);
                        Node<int> node3 = new Node<int>(3);
                        Node<int> node4 = new Node<int>(4);
                        Node<int> node5 = new Node<int>(5);


                        DoubleLinkedList<int> myList = new DoubleLinkedList<int>();
                        myList.AddLast(node1);
                        myList.AddLast(node2);

                        myList.AddBefore(node1, new Node<int>((-1)));
                        myList.AddBefore(node1.Previous, new Node<int>((-2)));
                        myList.AddBefore(myList.First, ((-3)));
                        myList.AddBefore(myList.First, ((-4)));

                        myList.AddLast(node3);
                        myList.AddLast(4);
                        myList.AddLast(5);
                        myList.AddLast(new Node<int> (6));

                        myList.AddFirst(new Node<int>((-5)));
                        myList.AddFirst(new Node<int>((-6)));
                        myList.AddFirst((-7));
                        myList.AddFirst((-8));

                        myList.AddAfter(myList.Contains(4), 4444);
                        myList.AddAfter(myList.Contains((-6)), (-6666));
                        myList.AddAfter(myList.Contains(1), new Node<int>(1111));
                        myList.AddAfter(myList.Contains(2), new Node<int>(2222));

                        myList.Remove(1111);
                        myList.Remove(myList.Contains(2222));
                        myList.Remove(4444);
                        myList.Remove(myList.Contains((-6666)));


                        Console.WriteLine("Total Elements: {0}", myList.Count);
                        for(Node<int> nodeTemp = myList.First; nodeTemp != null; nodeTemp = nodeTemp.Next)
                        {
                            Console.WriteLine(nodeTemp.Value);
                        }


                        Console.WriteLine("---------------------------------------");

                        myList[2] = 200;
                        myList[3] = myList[2] + 100;
                        myList[myList.Count - 1] = myList.Count * 100;
                        myList[myList.Count] = myList.Count * 100;//for exception
                        myList.Clear();
                        myList[myList.Count - 1] = 0;//for exception
                        for (Node<int> nodeTemp = myList.First; nodeTemp != null; nodeTemp = nodeTemp.Next)
                        {
                            Console.WriteLine(nodeTemp.Value);
                        }

                        Console.ReadLine();*/

        }
    }
}
