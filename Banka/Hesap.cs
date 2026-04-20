using System;

namespace Banka
{
    internal class Hesap
    {
        public int ID { get; set; }
        public string sahip { get; set; }
        public int bakiye { get; set; }
        public bool durum { get; set; }

        public Hesap(int _ID, string _sahip, int _bakiye, bool _durum)
        {
            this.ID = _ID;
            this.sahip = _sahip;
            this.bakiye = _bakiye;
            this.durum = _durum;
        }

        public override string ToString()
        {
            return $"Hesap Başarıyla Oluştu. Merhaba {sahip}, IDiniz: {ID} ve Bakiyeniz: {bakiye}.";
        }

        public virtual void ParaCek(int miktar)
        {
            if (bakiye < miktar)
            {
                Console.WriteLine("Yetersiz Bakiye.");
            }
            else if (miktar <= 0)
            {
                Console.WriteLine("Geçersiz Miktar.");
            }
            else
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} Para başarıyla çekildi. Mevcut Bakiye: {bakiye}");
            }
        }

        public void ParaYatır(int miktar)
        {
            if (miktar <= 0)
            {
                Console.WriteLine("Geçersiz Miktar.");
            }
            else
            {
                bakiye += miktar;
                Console.WriteLine($"{miktar} Para başarıyla yatırıldı. Mevcut Bakiye: {bakiye}");
            }
        }
    }
}