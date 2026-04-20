using System;
using System.Collections.Generic;

namespace Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            bool kontrol = false;
            List<Hesap> hesaplar = new List<Hesap>();

            while (true)
            {
                Console.WriteLine("İŞLEM\n1.Kayıt\n2.Giriş\n3.Çıkış");
                int cevapk = Int32.Parse(Console.ReadLine());

                if (cevapk == 1)
                {
                    Console.Write("İsim: ");
                    string isim = Console.ReadLine();

                    Console.Write("Öğrenim: ");
                    string öğrenim = Console.ReadLine();

                    if (öğrenim.ToLower() == "öğrenci")
                    {
                        kontrol = true;
                        Hesap hesap = new ÖHesap(i, isim, 500, kontrol);
                        hesaplar.Add(hesap);
                        Console.WriteLine(hesap);
                        i++;
                    }
                    else
                    {
                        kontrol = false;
                        Hesap hesap = new Hesap(i, isim, 500, kontrol);
                        hesaplar.Add(hesap);
                        Console.WriteLine(hesap);
                        i++;
                    }
                }
                else if (cevapk == 2)
                {
                    Console.Write("ID: ");
                    int ID = Int32.Parse(Console.ReadLine());

                    bool bulundu = false;

                    for (int j = 0; j < hesaplar.Count; j++)
                    {
                        if (hesaplar[j].ID == ID)
                        {
                            bulundu = true;

                            while (true)
                            {
                                Console.WriteLine("İŞLEM\n1.Para Çek\n2.Para Yatır\n3.Çıkış");
                                int cevap = Int32.Parse(Console.ReadLine());

                                if (cevap == 1)
                                {
                                    Console.Write("Miktar: ");
                                    int miktar = Int32.Parse(Console.ReadLine());
                                    hesaplar[j].ParaCek(miktar);
                                }
                                else if (cevap == 2)
                                {
                                    Console.Write("Miktar: ");
                                    int miktar = Int32.Parse(Console.ReadLine());
                                    hesaplar[j].ParaYatır(miktar);
                                }
                                else if (cevap == 3)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş.");
                                }
                            }
                            break;
                        }
                    }

                    if (!bulundu)
                    {
                        Console.WriteLine("Eşleşme Bulunamadı.");
                    }
                }
                else if (cevapk == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş.");
                }
            }
        }
    }
}