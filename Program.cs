﻿

namespace Stack
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                //Stack S = new Stack("One", "Two", "Three");
                //Stack S2 = new Stack("1", "2", "3");
                //Stack S3 = new Stack("Раз", "Два","Три");
                //Stack S4 = new Stack();

                while (true)
                {
                    var input = Console.ReadLine();
                    if (input == "exit") return;
                    Stack S = new Stack("One", "Two", "Three");
                    Console.WriteLine($"Верхний элемент: {S.Top}\nКол-во элементов: {S.Size}");
                }
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
