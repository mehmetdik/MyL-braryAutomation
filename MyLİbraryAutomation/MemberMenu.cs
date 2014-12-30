using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW2
{
    class MemberMenu
    {
        public void membermenu()
        {
            
            Console.WriteLine("1-Üye Ol");
            Console.WriteLine();
            Console.WriteLine("2-Üyeliği Bitir");
            Console.WriteLine();
            Console.WriteLine("3-Üye Ara");
            Console.WriteLine();
            Console.WriteLine("4-Kitap Ödünç Al");
            Console.WriteLine();
            Console.WriteLine("5-Ödünç Alınan Kitabı Geri Ver");
            Console.WriteLine();
            Console.WriteLine("6-Ana Menu'ye Dön");
            Console.WriteLine();
            Console.WriteLine();
           int Secim=Convert.ToInt32(Console.ReadLine());
            switch (Secim)
            {
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Console.Clear();
                    AnaMenu AnaMobj = new AnaMenu();
                    AnaMobj.Anamenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lütfen Menuda Bulunan Bir Seçeneği Seçiniz...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    membermenu();
                    break;
            }

        }
    }
}
