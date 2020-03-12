using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Code
{
    class Stack
    {
        private int[] myArray = new int[10];
        int top;
        public Stack()
        {
            top = -1;
            for(int row=0; row<10;row++)
            {
                myArray[row] = 0;
            }
        }
        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool IsFull()
        {
            if (top == 9)
                return true;
            else
                return false;
        }
        public void Display()
        {
            for(int row=10-1; row>=0;row--)
            {
                Console.WriteLine(myArray[row]);
            }
            Console.WriteLine();
        }
        public int Count()
        {
            return top + 1;
        }
        public void Push(int value)
        {
            if(IsFull())
            {
                Console.WriteLine("Stack Is Full");
            }
            else
            {
                top++;
                myArray[top] = value;
            }
        }
        public int Pop()
        {
            int popValue;
            if (IsEmpty())
            {
                Console.WriteLine("Stack Is Empty");
                return 0;
            }
            else
            {

                popValue = myArray[top];
                myArray[top] = 0;
                top--;
                return popValue;
            }

        }
        public int Peek(int Position)
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack Is Empty");
                return 0;
            }
            else
            {
                return myArray[Position];            }
        }
        public void Change(int Position,int Vaule)
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack Is Empty");
            }
            else
            {
                myArray[Position] = Vaule;
            }
        }
    }
}
