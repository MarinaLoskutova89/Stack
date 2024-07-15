using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack_old
    {
        private readonly List<string> stack;

        public Stack_old(params string[] input)
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
            string? topValue = stack.Last();
            try 
            {
                if (stack != null)
                {
                    stack.Remove(topValue);
                }
                else 
                {
                    throw new Exception("Empty stack!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return topValue;
        }

        public int Size { get => stack.Count; }
        public string? Top { get => stack?.Last(); }
        public static Stack_old Concat(params Stack_old[] Stack_olds)
        {
            Stack_old newStack_old = new Stack_old();

            foreach (Stack_old st in Stack_olds)
            {
                foreach (string str in st.stack.OrderDescending())
                {
                    newStack_old.Add(str);
                }
            }
            return newStack_old;
        }

        public IEnumerable<string> GetList() => stack.OrderByDescending(o => o);
    }
}
