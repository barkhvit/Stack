

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
                Stack S3 = new Stack("Раз", "Два","Три");
                Stack S4 = new Stack();

                while (true)
                {
                    var input = Console.ReadLine();
                    if (input == "exit") return;
                    var ss = Stack.Concat(S, S2, S3,S4);
                    ss.Print();
                }
            }
            catch (StackEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
