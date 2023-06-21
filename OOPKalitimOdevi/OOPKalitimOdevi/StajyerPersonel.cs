using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdevi
{
    public class StajyerPersonel : PersonBase, IMaasHesapla
    {
        
        public double Saat { get; set; }
        public double Saatlik { get; set; }

        public StajyerPersonel()
        {
            
        }

        public StajyerPersonel(string id, string firstName, string lastName,double saat,double saatlik) : base(id, firstName, lastName)
        {
            Saat = saat;
            Saatlik = saatlik;
        }

        

        public double MaasHesapla() => Math.Round((Saat * Saatlik),2);

        public override string AdSoyadGetir()
        {
            return $"{base.AdSoyadGetir()}\nBir Ayda Çalıştığı Saat : {Saat}\nSaatlik Ücreti : {Saatlik} TL\nAylık Maaşı : {MaasHesapla()} TL";
        }
    }
}
