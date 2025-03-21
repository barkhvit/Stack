

namespace Stack
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Stack S = new Stack("One", "Two", "Three");
                Stack S2 = new Stack("1", "2", "3");

                while (true)
                {
                    var input = Console.ReadLine();
                    if (input == "exit") return;
                    S.Merge(S2);
                    S.Print();
                }
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
