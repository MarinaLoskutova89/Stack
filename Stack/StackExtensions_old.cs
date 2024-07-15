using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public static class StackExtensions_old
    {
        public static void Merge(this Stack_old stack1, Stack_old stack2)
        {
            foreach (var st2 in stack2.GetList())
            {
                stack1.Add(st2);
            }
        }
    }
}
