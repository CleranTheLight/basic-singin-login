using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_14
{
    internal class Customer
    {
        internal static ArrayList Database = new ArrayList();    
        internal static ArrayList goruntulenecek_Database = new ArrayList();


        

        internal string data(string isim, string soyisim, string email, string kullaniciAdi, string sifre, string id)
        {

            string item = isim + "/" + soyisim + "/" + email + "/" + kullaniciAdi + "/" + sifre + "/"+ id ;
            return item;
        }

        

        public int ID_olustur()
        {
            Random rand = new Random();
            int id = rand.Next(1000000, 9000000);
            return id;
        }

        internal void kullanıcı_bilgi_goruntuleme(string kullaniciAdi_yada_email, string sifre)
        {
            for (int i = 0; i < Database.Count; i++)
            {
                string kullanıcıDataAyrılmamis = Convert.ToString(Customer.Database[i]);


                string[] kullaniciData = kullanıcıDataAyrılmamis.Split('/');

                bool usernameOrEmail = (kullaniciAdi_yada_email == kullaniciData[2] || kullaniciAdi_yada_email == kullaniciData[3] );
                bool sifreKontrol = (sifre == kullaniciData[4]);

                if (usernameOrEmail && sifreKontrol)
                {
                    

                    Console.WriteLine("Kullanıcı girişi yapılmıştır.");
                    Console.WriteLine("Kullanıcı bilgileri :");

                    foreach (string item in kullaniciData)
                    {
                        Console.WriteLine("-" + item);
                    }
                }
            }
        }

    }
}
