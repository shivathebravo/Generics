using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { ISBN = "12321", Title = "C# adv" };
            // var number = new List();
            // number.Add(book);

            // var books = new BookList();
            // books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(20);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var number = new Nullable<int>(5);
            Console.WriteLine("has aValue" ? number.HasValue); ;
            Console.WriteLine( "valeu"+ number.GetValueOrDefault());
        }
    }

    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
            }
    }
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

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
}
