namespace Atelier.Exceptions
{
    internal class BookAlreadyExistException : Exception
    {
        public BookAlreadyExistException(string message) : base(message) { }
    }
}
