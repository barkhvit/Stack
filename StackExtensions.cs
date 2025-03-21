using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public static class StackExtensions
    {
        public static void Merge(this Stack s,Stack s1 )
        {
            if (s.stack.Count==0)
                return;
            for (int i = s1.stack.Count - 1; i >= 0; i--)
            {
                s.stack.Add(s1.stack[i]);
            }

        }
    }
}
