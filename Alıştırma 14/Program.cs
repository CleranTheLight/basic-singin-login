using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer();
            Helper kontrol = new Helper();


            do
            {

                Console.WriteLine("Kullanıcı kayıt için 1, kullanıcı girişi için 2'ye basınız.");

                string kullaniciSecim = Console.ReadLine();
                Console.Clear();
                switch (kullaniciSecim)
                {
                    case "1":   // değer ekleme
                        string kontrolData = Helper.Tanımlama();

                        if (Customer.Database.Count >= 1)
                        {
                            Helper.GenelKontrol(kontrolData);
                        }
                        else
                        {
                            Customer.Database.Add(kontrolData);
                        }
                        break;


                    case "2": // kullanıcı girişi ve kullanıcı bilgileri

                        Console.Clear();
                        Console.Write("Kullanıcı adınızı ya da emailinizi giriniz: ");
                        string kullaniciadi_email = Console.ReadLine();
                        Console.Write("Şifrenizi giriniz: ");
                        string sifre = Console.ReadLine();

                        Console.Clear();
                        customer.kullanıcı_bilgi_goruntuleme(kullaniciadi_email, sifre);
                        break;


                }





            } while (true);

            

        }
    }
}
