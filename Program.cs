

namespace Stack
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Stack S = new Stack("One", "Two", "Three");

                while (true)
                {
                    var input = Console.ReadLine();
                    if (input == "exit") return;

                    Console.WriteLine(S.Top);
                    Console.WriteLine(S.Size);
                    S.Pop();
                    Console.WriteLine(S.Top);
                    Console.WriteLine(S.Size);
                    S.Pop();
                    Console.WriteLine(S.Top);
                    Console.WriteLine(S.Size);
                    S.Pop();
                    Console.WriteLine(S.Top);
                    Console.WriteLine(S.Size);
                    S.Pop();
                    Console.WriteLine(S.Top);
                    Console.WriteLine(S.Size);
                    S.Pop();
                }
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
