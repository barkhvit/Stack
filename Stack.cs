using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private class StackItem//Элемент списка
        {
            public string Value { get; }
            public StackItem Previous { get; }
            public StackItem(string value,StackItem stackItem)
            {
                Value = value;
                Previous = stackItem;
            }
        }

        public Stack(params string[] item)
        {
            
        }

        public void Add(string item)
        {

        }


    }
}
