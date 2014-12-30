using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW2
{
    class Test
    {
        static void Main(string[] args)
        {
            //AnaMenu AnaMenuObj = new AnaMenu();
            //AnaMenuObj.Anamenu();
            LinkedList<Book> deneme = new LinkedList<Book>();
            Console.WriteLine("dsd");
            deneme.addToEnd(new Book("Mai ve Siyah", 1234, "Ali", "dram"));
            deneme.addToEnd(new Book("book2", 1234, "Ali", "dram"));
            deneme.addToEnd(new Book("book3", 1234, "Ali", "dram"));

            //Console.WriteLine(deneme.donder(2)); 
            deneme.display();
            
        }
    }
}
