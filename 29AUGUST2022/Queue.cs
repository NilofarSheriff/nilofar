using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
    
        public class UserQueue
        {
            int rear, front;
            int capacity;
            public int [] queue;
            public UserQueue(int c)
            {
                rear = 0; front = 0;
                capacity = c;
                queue = new int[capacity];

            }
            public void Queueenqueue(int data)
            {
                if(rear < capacity)
                {
                    queue[rear] = data;
                    rear++;
                }
                else
                {
                    Console.WriteLine("Queue is full");
                }
            }

            public void Queuedequeue()
            {
                if(front == rear)
                {
                    Console.WriteLine("The Queue is empty");

                }
                else
                {
                    for(int i=front; i < rear - 1; i++)
                    {
                        queue[i] = queue[i+1];  
                    }
                    queue[rear] = 0;
                     rear--;
                }
            }

            public void displaydetails()
            {



            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }
            else
            {
                for (int i = front; i < rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }

            }
            
            }

            public void peekqueue()
            {
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }
            else
            {
                Console.WriteLine(queue[front]);

            }

           
            }
        }

    
}
