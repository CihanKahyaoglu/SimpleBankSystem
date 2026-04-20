using System;

namespace Banka
{
    internal class ÖHesap : Hesap
    {
        public ÖHesap(int id, string sahip, int bakiye, bool durum) : base(id, sahip, bakiye, durum) 
        { 

        }

        public override void ParaCek(int miktar)
        {
            if (miktar <= 0)
            {
                Console.WriteLine("Geçersiz Miktar.");
            }
            else if (bakiye < miktar + miktar * 1 / 10)
            {
                Console.WriteLine("Yetersiz Bakiye.");
            }

            bakiye -= miktar + miktar * 1 / 10;
            Console.WriteLine("Komisyon Çekildi.");
            Console.WriteLine($"{miktar} Para başarıyla çekildi. Mevcut Bakiye: {bakiye}");
        }
    }
}