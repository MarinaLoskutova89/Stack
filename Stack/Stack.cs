using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        static class StackItem 
        {
            private static string _currentValue;
        }

        public List<string> stack;

        public Stack(params string[] input)
        {
            var listOfInputs = new List<string>();
            foreach (string s in input)
            {
                listOfInputs.Add(s);
            }
            this.stack = listOfInputs;
        }

        public List<string> Add(string inputString)
        {
            stack.Add(inputString);
            return stack;
        }

        public string Pop()
        {
            string topValue;
            try 
            {
                topValue = stack.Last();
                stack.Remove(topValue);
            }
            catch
            {
                throw new Exception("Empty stack!");
            }
            return topValue;
        }

        public int Size { get => stack.Count; }
        public string Top
        {
            get
            {
                if (stack.Count == 0) return "null";
                else return stack.Last();
            }
        }
        public static Stack Concat(params Stack[] stacks)
        {
            Stack newStack = new Stack();

            foreach (Stack st in stacks)
            {
                foreach (string str in st.stack.OrderDescending())
                {
                    newStack.Add(str);
                }
            }
            return newStack;
        }
    }
}
