using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW2
{
    class BookOperations<T> where T : IComparable
    {
        LinkedList<Book> objAddBook = new LinkedList<Book>();
        public void AddBook()
        {

            Book objBook = new Book();


            Console.WriteLine("Kitap ISBN No:");
            int ısbnNo = Convert.ToInt32(Console.ReadLine());
            objBook.setBookISBNno(ısbnNo);

            Console.WriteLine("Kitap ismi:");
            string bookName = Console.ReadLine();
            objBook.setBookName(bookName);

            Console.WriteLine("Yazar ismi:");
            string Writer = Console.ReadLine();
            objBook.setWriter(Writer);

            Console.WriteLine("Kitap Türü:");
            string Type = Console.ReadLine();
            objBook.setType(Type);

            objAddBook.addToFront(objBook);
        }
    }
}
