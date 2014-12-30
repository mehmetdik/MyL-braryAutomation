using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW2
{
    class Book : IComparable
    {
        string BookName;
        int BookISBNno;
        string Writer;
        string Type;

        public Book(string BookName, int BookISBNno, string Writer, string Type)
        {
            this.BookName = BookName;
            this.BookISBNno = BookISBNno;
            this.Writer = Writer;
            this.Type = Type;

        }

        public Book()
        {
            // TODO: Complete member initialization
        }

        public string getBookName()
        {
            return BookName;
        }

        public void setBookName(string BookName)
        {
            this.BookName = BookName;
        }



        public int getBookISBNno()
        {
            return BookISBNno;
        }

        public void setBookISBNno(int BookISBNno)
        {
            this.BookISBNno = BookISBNno;
        }



        public string getWriter()
        {
            return Writer;
        }

        public void setWriter(string Writer)
        {
            this.Writer = Writer;
        }



        public string getType()
        {
            return Type;
        }

        public void setType(string Type)
        {
            this.Type = Type;
        }


        //public override string ToString()
        //{
        //    return "Bookname..: " + BookName + "BookISBNno...: " + BookISBNno + "Writer" + Writer + "Type" + Type;
        //}

        public override string ToString() {
            return "1";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
