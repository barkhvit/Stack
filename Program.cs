

namespace Stack
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    var input = Console.ReadLine();
                    if (input == "exit") return;
                    Stack S = new Stack("One", "Two", "Three","Four");
                    Console.WriteLine($"Верхний элемент: {S.Top}\nКол-во элементов: {S.Size}");
                    Console.WriteLine("----------------------------------------------------");
                    S.Pop();
                    Console.WriteLine($"Верхний элемент: {S.Top}\nКол-во элементов: {S.Size}");
                    Console.WriteLine("----------------------------------------------------");
                    S.Pop();
                    Console.WriteLine($"Верхний элемент: {S.Top}\nКол-во элементов: {S.Size}");
                    Console.WriteLine("----------------------------------------------------");
                    S.Pop();
                    Console.WriteLine($"Верхний элемент: {S.Top}\nКол-во элементов: {S.Size}");
                    Console.WriteLine("----------------------------------------------------");
                    S.Pop();
                    Console.WriteLine($"Верхний элемент: {S.Top}\nКол-во элементов: {S.Size}");
                    Console.WriteLine("----------------------------------------------------");
                    S.Pop();
                    Console.WriteLine($"Верхний элемент: {S.Top}\nКол-во элементов: {S.Size}");
                    Console.WriteLine("----------------------------------------------------");
                }
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
