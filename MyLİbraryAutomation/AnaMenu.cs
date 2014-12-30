using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW2
{
    class AnaMenu
    {
        public void Anamenu()
        {        

             Console.WriteLine("1-Kitap islemleri");
             Console.WriteLine();
             Console.WriteLine("2-Üye islemleri");
             Console.WriteLine(); 
             Console.WriteLine();
             Console.WriteLine("Bir islem türünü seciniz(1/2):");
             int secim =Convert.ToInt32(Console.ReadLine());
             switch (secim)
             {
                 case 1:
                     Console.Clear();
                     BookMenu bookobj = new BookMenu();
                     bookobj.bookmenu();
                     break;
                 
                 case 2:
                     Console.Clear();
                     MemberMenu memberobj = new MemberMenu();
                     memberobj.membermenu();
                     break;
                 
                 default:
                    Console.Clear();
                    Console.WriteLine("Lütfen Menuda Bulunan Bir Seçeneği Seçiniz...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Anamenu();
                     break;
             }
        }

    }
}
