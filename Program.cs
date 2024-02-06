namespace Generics
{
    public class Utilities
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b)>0 ? a : b;
        }
    }
    class Book
    {
        private int Isbn;
        private string Title;

        public Book(int isbn, string title)
        {
            this.Isbn = isbn;
            this.Title = title;
        }

    }
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            var book = new Book(1111, "C# Advanced");

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);
        }
    }
}