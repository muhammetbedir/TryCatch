using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchh
{
    internal class Program
    {
        public void DokuzaTamBölünen()
        {
        // sayi'nin için de 9 a tam bölünen sayıların toplamı
        start:
            bool isTrue = true;
            int toplam = 0;
            while (isTrue)
            {
               
                try
                {
                    
                    Console.WriteLine("Pozitif Bir Tam Sayı Giriniz....");
                    int number = int.Parse(Console.ReadLine());
                    if (number > 0)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            
                            if (i % 9 == 0)
                            {
                                toplam += i;
                                Console.WriteLine("-" + i);
                            }

                            isTrue = false;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Pozitif Bir Tam Sayı Giriniz...");
                        goto start;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("!!!Hatalı girdi...");
                    goto start;
                }
                Console.WriteLine("Sayıların toplamı : " + toplam);
                Console.ReadLine();
            }

        }
        public void IsPrime()
        {
        start:
            try
            {
                Console.WriteLine("Lütfen Bir Sayı Giriniz....");
                bool isTrue = true;
                int number = int.Parse(Console.ReadLine());
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isTrue = false;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine($"{number} bir asal sayıdır.");
                }
                else
                {
                    Console.WriteLine($"{number} bir asal sayı değildir.");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Hatalı girdi. Tekrar giriş yapınız.");
                goto start;
            }

        }
        public void Faktoriyel()
        {
            bool isTrue = true;
            while (isTrue)
            {
                try
                {
                    Console.WriteLine("Bir tam sayı giriniz...");
                    int number = int.Parse(Console.ReadLine());
                    int faktoriyel = 1;
                    for (int i = number; i > 0; i--)
                    {
                        faktoriyel = faktoriyel * i;
                    }
                    Console.WriteLine("Sonuç : "+faktoriyel);
                    isTrue = false;
                 }
                catch (Exception)
                {
                    Console.WriteLine("!!Yanlış girdi.");

                }
            }
        }
        public void Char()
        {
            bool isTrue = true;
            while (isTrue)
            {
                try
                {
                    Console.WriteLine("Bir tuşa basınız...");
                    char chr = char.Parse(Console.ReadLine());
                    if (chr >= 'A' && chr <= 'Z' || chr >= 'a' && chr <= 'z' )
                    {
                        Console.WriteLine("Harf tuşuna bastınız.");
                    }
                    else if (chr >= '0' && chr <= '9')
                    {
                        Console.WriteLine("Rakam tuşuna bastınız.");

                    }
                    else
                    {
                        Console.WriteLine("Özel karakter girdiniz.");

                    }
                    isTrue = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("!!Hatalı tuşlama yaptınız...");
                }
            }
        }
        public void EnKucuk()
        {
            bool isTrue = true;
            while (isTrue)
            {
                try
                {
                    Console.WriteLine("Birinci sayıyı giriniz...");
                    int a, b, c;
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("İkinnci sayıyı giriniz...");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Üçüncü sayıyı giriniz...");
                    c = int.Parse(Console.ReadLine());
                    if (a< b && a < c)
                    {
                        Console.WriteLine($"{a} sayısı en küçüktür.");
                    }
                    else if (b < a && b < c)
                    {
                        Console.WriteLine($"{b} sayısı en küçüktür.");

                    }
                    else
                    {
                        Console.WriteLine($"{c} sayısı en küçüktür.");

                    }
                    isTrue = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("!!Hatalı tuşlama yaptınız tekrar deneyiniz...");
                }
            }
        }
        public void DenkleminKokleri()
        {
            // Klavyeden girilen 2.dereceden denklemin köklerini bulma

            double a = 0, b = 0, c = 0, delta, x1, x2;
            Console.WriteLine("ax2 + bx + c = 0 denklemi için");
            bool isTrue = true;
            while (isTrue)
            {
                try
                {
                    Console.WriteLine("a katsayısını giriniz: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    isTrue = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }
            isTrue = true;
            while (isTrue)
            {
                try
                {
                    Console.WriteLine("b katsayısını giriniz: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    isTrue = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }
            isTrue = true;
            while (isTrue)
            {
                try
                {
                    Console.WriteLine("c katsayısını giriniz: ");
                    c = Convert.ToInt16(Console.ReadLine());
                    isTrue = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }

            delta = b * b - 4 * a * c;
            if (delta >= 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("1.Kök = {0} ", x1);
                Console.WriteLine("2.Kök = {0} ", x2);
            }
            else if (delta < 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Tek Kök = {0}", x1);
            }
            else
            {
                Console.WriteLine("Kök Yok");
            }
          
           

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.DokuzaTamBölünen();
            //program.IsPrime();
            //program.Faktoriyel();
            //program.Char();
            //program.EnKucuk();
            //program.DenkleminKokleri();


            Console.Read();
        }
    }
}
