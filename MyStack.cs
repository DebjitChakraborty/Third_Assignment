using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Assignment
{
    internal class MyStack:ICloneable
    {
        private int top = 0;
        private int size;
        private int[] stack;
        public MyStack(int size)
        {
            this.size = size;
            stack = new int[size];
        }
        public bool IsEmpty()
        {
            if (top == 0)
                return true;
            else
                return false;
        }
        public void Push(int element)
        {
            if (top > size)
                throw new Exception("Stack Overflow");
            stack[top] = element;
            top++;
        }
        public int Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack Underflow");
            else
            {
                top--;
                return stack[top];
            }
        }
        public object Clone()
        {
            return new MyStack(size);
        }
        public override string ToString()
        {
            return size.ToString();
        }

    }
}
