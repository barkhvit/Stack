using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        public List<string> stack = new List<string>();

        public string Top { get
            {
                if (stack.Count == 0)
                    return null;

                return stack[stack.Count - 1];

            } }
        public Stack(params string[] parameters)
        {
            foreach (var parameter in parameters)
            {
                Add(parameter);
            }
        }
        public void Add(string name)
        {
            stack.Add(name);
        }

        public void Print()
        {
            foreach (var parameter in stack) 
                Console.WriteLine(parameter.ToString());
        }

        

    }
}
