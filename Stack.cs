using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private StackItem Item = new StackItem();//элемент стэка
        private int _size; //кол-во элементов
        private class StackItem//Элемент списка
        {
            public string Value { get; }
            public StackItem Previous { get; }
            public StackItem()
            {
                
            }
            public StackItem(string value,StackItem stackItem)
            {
                Value = value;
                Previous = stackItem;
            }
        }

        public Stack(params string[] item)
        {
            foreach(string i in item)
            {
                Add(i);
            }
        }

        public void Add(string item)
        {
            Item = new StackItem(item,Item);
            _size++;
        }

        public string Top {  get { return Item.Value; } } //значение верхнего элемента
        public int Size {  get { return _size; } } //кол-во элементов

        public void Pop()
        {
            if(_size > 0)
            {
                Console.WriteLine(Item.Value);
                Item = Item.Previous;
                _size--;
            }
            else throw new StackEmptyException();
            
        }
    }
}
