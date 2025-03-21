
namespace Stack
{
    [Serializable]
    internal class StackEmptyException : Exception
    {
        public StackEmptyException():base("Стэк пустой")
        {
        }

        public StackEmptyException(string? message) : base(message)
        {
        }

        public StackEmptyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}