using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProj
{
    public class gqueue<T> where T : class
    {
        private  T[] queue;
        private int head=-1;
        private int tail=-1;
        private int capacity;

        public gqueue(int capacity) { 
            this.capacity = capacity;
            queue = new T[capacity];
        }

        public void enqueue(T item)
        {
            if (tail +1 == capacity)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                if (head == -1 && tail == -1)
                {
                    head = 0;
                    tail = 0;
                }
                else
                {
                    tail = tail + 1;
                }
                queue[tail] = item;
            }
        }


        public T dequeue()
        {
            T Item;
            if (head > tail || tail == -1)
            {
                Console.WriteLine("Queue is Empty");
                throw new Exception("Empty");
            }
            else
            {
                Item = queue[head];
                if (head == tail)
                {
                    tail = -1;
                    head = -1;
                }
                else
                {


                    head = head + 1;

                }
                return Item;
            }
        }
        

        public bool IsEmpty()
        {
            return head == tail;
        }

        public bool IsFull()
        {
            return head > tail;
        }

    }
}
