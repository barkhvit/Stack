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
        //стэк для хранения
        public List<string> stack = new List<string>();

        public Stack(params string[] parameters)
        {
            foreach (var parameter in parameters)
            {
                Add(parameter);
            }
        }
        public string? Top //возвращает последний элемент списка
        { get
            {
                if (Size == 0)
                    return null;

                return stack[stack.Count - 1];
            } 
        }

        public int Size//возвращает кол-во элементов в стэке
        {
            get { return stack.Count; }
        }
        
        public void Add(string name)//добавляет элемент в стэк
        {
            stack.Add(name);
        }

        public void Pop()//возвращает и удаляет последний элемент
        {
            if (String.IsNullOrEmpty(Top))
                throw new StackEmptyException();
            Console.WriteLine($"Последний элемент списка: {Top}");
            stack.Remove(Top);
        }
        public void Print()
        {
            foreach (var parameter in stack) 
                Console.WriteLine(parameter.ToString());
        }

        

    }
}
