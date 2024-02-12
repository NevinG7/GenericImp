using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProj
{
    public class gstack<T> where T : struct
    {
        private T[] stack;
        private int top = -1;
        private int maxlen = 0;

        public gstack(int maxlen) {
            this.maxlen = maxlen;
            this.stack = new T[maxlen];
        }
        public void Push(T input)
        {
            if (top >= maxlen)
            {
                Console.WriteLine("Full");
                return;
            }
            stack[++top] = input;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Already Empty");
                throw new Exception("Empty");
            }

            T item= stack[top--];
            return item;
        }
        
        public T Peek()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Empty");
            }
            T item= stack[top];
            return item;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }


    }
}
