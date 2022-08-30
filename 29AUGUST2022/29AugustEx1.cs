using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
    public class _29AugustEx1
    {
        class Program
        {
            public class linkedNode<T>
            {
                public linkedNode<T> next;
                public T Data;
                public linkedNode(T Data)
                {
                    this.Data = Data;
                }
            }

            public class linked<T>
            {
                public linkedNode<T> Head
                {
                    get
                    {
                        return head;
                    }
                }
                private linkedNode<T> head;
                private linkedNode<T> tail;
                public void AddFirst(linkedNode<T> node)
                {
                    if (head == null)
                    {
                        head = tail = node;
                        head.next = tail;
                    }
                    else
                    {
                        node.next = head;
                        head = node;
                    }
                }

                public void AddLast(linkedNode<T> node)
                {
                    if (tail == null)
                    {
                        tail = head = node;
                        head.next = tail;
                    }
                    else
                    {
                        tail.next = node;
                        tail = node;
                    }
                }

                // inserting after a node is much easier than before a node in a singly linked list because there is no 
                // pointer to the node pointing at the current, unlike a doubly linked list.
                public void insertAfter(linkedNode<T> nodeBefore, linkedNode<T> node)
                {
                    linkedNode<T> nodeAfter = nodeBefore.next;
                    nodeBefore.next = node;
                    node.next = nodeAfter;

                }

                public void removeLink(linkedNode<T> node)
                {
                    linkedNode<T> nodeBefore = FindNodeBefore(node);
                    // if node not found, just return
                    if (nodeBefore == null)
                        return;
                    if (object.ReferenceEquals(head, node))
                    {
                        head = node;
                    }
                    if (object.ReferenceEquals(tail, node))
                    {
                        tail = nodeBefore;
                    }

                    nodeBefore.next = node.next;
                }

                // finding the node before the current requires traversal of a singly linked list.
                public linkedNode<T> FindNodeBefore(linkedNode<T> node)
                {
                    // there is no node before the head, so return null
                    if (object.ReferenceEquals(node, head))
                        return null;
                    linkedNode<T> nodeBefore = head;
                    linkedNode<T> cursor = head;
                    while (cursor != null)
                    {

                        if (object.ReferenceEquals(node, cursor))
                            return nodeBefore;

                        nodeBefore = cursor;

                        cursor = cursor.next;
                    }
                    //if nothing found, return null
                    return null;
                }
            }
            static void Main(string[] args)
            {
                linked<string> list = new linked<string>();
                list.AddFirst(new linkedNode<string>("Nilofar"));
                list.AddFirst(new linkedNode<string>("zamruth"));
                list.AddLast(new linkedNode<string>("mehar"));
                list.AddLast(new linkedNode<string>("varshini"));
                list.AddFirst(new linkedNode<string>("israth"));
                list.AddLast(new linkedNode<string>("sathya"));
                linkedNode<string> newLastNode = new linkedNode<string>("sheriff");
                list.AddLast(newLastNode);
                list.insertAfter(newLastNode, new linkedNode<string>("inserted first after the last"));
                list.insertAfter(newLastNode, new linkedNode<string>("inserted second after the last, but will appear right after the last"));

                DisplayAllNodes(list);

                Console.WriteLine("list2 items are being displayed");
                linked<string> list2 = new linked<string>();

                list2.AddLast(new linkedNode<string>("sruthi"));
                list2.AddLast(new linkedNode<string>("universe"));
                linkedNode<string> thirdItem = new linkedNode<string>("Galaxy");
                list2.AddLast(thirdItem);
                list2.AddLast(new linkedNode<string>("Stars"));
                list2.AddLast(new linkedNode<string>("moon"));

                list2.removeLink(thirdItem);

                DisplayAllNodes(list2);


                Console.ReadLine();
            }

            private static void DisplayAllNodes(linked<string> list)
            {
                linkedNode<string> cursor = list.Head;
                while (cursor != null)
                {
                    Console.WriteLine(cursor.Data);
                    cursor = cursor.next;
                }
            }

        }
    }
}
