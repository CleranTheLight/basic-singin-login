using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_14
{
    internal class Helper
    {
        internal static void GenelKontrol(string data)
        {

            ArrayList Data_base = new ArrayList();
            Data_base = Customer.Database;

            string[] ayrilma = data.Split('/');

            string emailControl = ayrilma[2];
            string usernameControl = ayrilma[3];

            for(int i = 0; i < Data_base.Count; i++)
            {

                string DatabaseEleman = Convert.ToString(Data_base[i]);
                string[] ayrilmaKontrol = DatabaseEleman.Split('/');

                bool kontrolbool = (emailControl == ayrilmaKontrol[2] || usernameControl == ayrilmaKontrol[3]);
                if (kontrolbool == false)
                {
                    Customer.Database.Add(data);

                }
                else
                {
                    Console.WriteLine("Bu kullanıcı adına ya da email adresine sahip başka bir hesap bulunmaktadır, lütfen farklı bir kullanıcı adı ya da email adresi giriniz");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    break;
                }
            }



          
        }

        internal static string Tanımlama()
        {
            d1:
            Customer customer = new Customer();
            Console.WriteLine("Adınızı Giriniz :");
            string name = Console.ReadLine();
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Bu kısmı boş bırakamazsınız.");
                System.Threading.Thread.Sleep(2000);
                goto d1;
            }

            d2:
            Console.WriteLine("Soyadınızı giriniz :");
            string surname = Console.ReadLine();
            if (String.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Bu kısmı boş bırakamazsınız.");
                System.Threading.Thread.Sleep(2000);
                goto d2;
            }

            d3:
            Console.WriteLine("Email adresinizi giriniz :");
            string email = Console.ReadLine();
            if (String.IsNullOrEmpty(email))
            {
                Console.WriteLine("Bu kısmı boş bırakamazsınız.");
                System.Threading.Thread.Sleep(2000);
                goto d3;
            }

            d4:
            Console.WriteLine("Bir kullanıcı adı giriniz :");
            string username = Console.ReadLine();
            if (String.IsNullOrEmpty(username))
            {
                Console.WriteLine("Bu kısmı boş bırakamazsınız.");
                System.Threading.Thread.Sleep(2000);
                goto d4;
            }

            Console.WriteLine("Kendinize bir şifre belirleyin :");
            string password = Console.ReadLine();

            Console.WriteLine("ID'niz tanımlanıyor...");
            a1:

            string ID = null;
            string ID_olusturma = Convert.ToString(customer.ID_olustur());
            if (Customer.Database.Count != 0) 
            { 
                foreach(string item in Customer.Database)
                {
                
                    string[] ID_kontrol = item.Split('/');
                    bool ID_kontrolbool = (ID_olusturma == ID_kontrol[5]);
                    if (ID_kontrolbool)
                    {
                        goto a1;
                    }
                    else
                    {
                        ID = ID_olusturma;
                        Console.WriteLine($"ID'niz {ID} olarak oluşturulmuştur.");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }
            else
            {
                ID = ID_olusturma;
                Console.WriteLine($"ID'niz {ID} olarak oluşturulmuştur.");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
           


            string kontroldata = customer.data(name, surname, email, username, password, ID);
            

            return kontroldata;


        }

        
    }
}
