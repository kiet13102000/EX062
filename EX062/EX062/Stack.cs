using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX062
{
    class Stack
    {
        public int[] Buffer;
        public int top;
        public Stack (int size)
        {
            Buffer = new int[size];
        }
       
         
        public void Push(int a)
        {
          Buffer[top++] = a;
        }
        public int Pop()
        {
            return Buffer[--top];
        }
        public int Peek()
        {
            return Buffer[top];
        }
        public int Count()
        {
            return top;
        }
        public void clear()
        {
            top = -1;
        }
    }
}
