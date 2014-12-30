using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW2
{
    class BookMenu
    {
        BookOperations<Book> addTemp = new BookOperations<Book>();
        public void bookmenu()
        {
            //int sec=0,sec2=0;
            //do
            //{



            Console.WriteLine("1-Yeni Kitap Ekle");
            Console.WriteLine();
            Console.WriteLine("2-Kitap Sil");
            Console.WriteLine();
            Console.WriteLine("3-Kitap Ara");
            Console.WriteLine();
            Console.WriteLine("4-Kitapları İsim Sırasına Göre Listele");
            Console.WriteLine();
            Console.WriteLine("5-Kitapları Tür Bilgisine Göre Listele");
            Console.WriteLine();
            Console.WriteLine("6-Ödünç Alınan Kitaplar");
            Console.WriteLine();
            Console.WriteLine("7-Ana Menu'ye Dön");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Secim Yapınız(Ör:4):");
            int Secim = Convert.ToInt32(Console.ReadLine());

            switch (Secim)
            {
                case 1:

                    addTemp.AddBook();
                    //sec2=Sor(sec);

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
                    break;
                case 7:
                    Console.Clear();
                    AnaMenu AnaMobj = new AnaMenu();
                    AnaMobj.Anamenu();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Lütfen Menuda Bulunan Bir Seçeneği Seçiniz...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    bookmenu();
                    break;

            }

            //} while (sec2==1);
        }
        //public int Sor(int sec)
        //{
        //    Console.WriteLine("Baska islem yapmak istiyor musunuz(1-Evet/2-Hayır)?");
        //    sec=Convert.ToInt32(Console.ReadLine());
        //    return sec;
        //}
    }
}
