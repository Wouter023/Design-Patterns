using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class ArrayStack : IStack
    {
        private int count;
        private int[] stackArray;

        public ArrayStack(int arraysize)
        {
            count = 0;
            stackArray = new int[arraysize];
        }

        public int Count
        {
            get { return count; }        
        }

        public bool isEmpty
        {
            get
            {
                return count == 0;
            }
        }

        public bool Contains(int value)
        {
            return stackArray.Contains(value);
        }

        public int Pop()
        {
            if(count == 0)
            {
                throw new Exception($"");
            }
            count--;
            return stackArray[count];
        }

        public void Push(int value)
        {
            try
            {
                stackArray[count] = value;
                count++;
            }
            catch
            {
                throw new Exception("Stack is full");
            }
        }
    }
}
