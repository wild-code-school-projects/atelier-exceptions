namespace Atelier.Exceptions
{
    internal class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message) { }
    }
}
