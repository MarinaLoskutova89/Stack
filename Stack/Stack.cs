using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private StackItem? _head;
        private int _size;
        private class StackItem
        {
            public StackItem(string s)
            {
                this.CurrentValue = s;
            }
            public string CurrentValue { get; }
            public StackItem? PreviouseValue { get; set; }
        }

        public Stack(params string[] input)
        {
            foreach (string s in input)
            {
                Add(s);
            }
        }

        public void Add(string inputString)
        {
            var newHead = new StackItem(inputString);

            newHead.PreviouseValue = _head;
            _head = newHead;
            _size++;
        }

        public string Pop()
        {
            string? removedValue = _head?.CurrentValue;
            try
            {
                if (_head != null)
                {
                    _head = _head?.PreviouseValue;
                    _size--;
                }
                else throw new Exception("Empty stack!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return removedValue;
        }

        public int Size { get => _size; }
        public string? Top { get => _head?.CurrentValue; }

        public static Stack Concat(params Stack[] stacks)
        {
            Stack newStack = new Stack();

            foreach (Stack st in stacks)
            {
                while (st.Size != 0)
                {
                    newStack.Add(st.Top);
                    st.Pop();
                }
            }
            return newStack;
        }
    }
}
