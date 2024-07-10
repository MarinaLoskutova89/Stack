using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public static class StackExtensions
    {
        public static void Merge(this Stack stack1, Stack stack2)
        {
            foreach (var st2 in stack2.stack.OrderDescending())
            {
                stack1.stack.Add(st2);
            }
        }
    }
}
