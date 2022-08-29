using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29August
{
   public class Userstack<T>
    {
      
        public T[] sstack;
        public int top, capacity;
        public Userstack(int c)
        {
            capacity = c; top = -1;
            sstack = new T[capacity];
           
        }
        public bool isempty()
        {
            return top < 0;
           
        }
        public void Stackpush(T data)
        {
            if (top >= capacity)
            {
                Console.WriteLine("No space in stack");
            }
            else
            {
                
                sstack[++top] = data;
              
            }
            
        }

        public void Stackpop()
        {
            
            if (top < 0)
            {
                Console.WriteLine("No elements in stack");

            }
            else
            {
              T value= sstack[top--];
                

            }
        }

        public void Stackpeek()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on the stack");
                return;
            }
            else
            {
                T value = sstack[top];
               // Console.WriteLine(value);
            }
            Console.WriteLine("The peek value is" + sstack[top]);
        }

        public void displaydetails()
        {
            if (top < 0)
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                Console.WriteLine("The elements in stack are:");
                for (int i = top; i > 0; i--)
                {
                    Console.WriteLine(sstack[i]);
                }

            }
            
        }
    }
}
