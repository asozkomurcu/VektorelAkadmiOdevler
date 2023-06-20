using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdevi
{
    public class SozlesmeliPersonel : PersonBase, IMaasHesapla
    {
        public byte Gun { get ; set; }
        public double Gunluk { get; set; }

        public SozlesmeliPersonel()
        {
              
        }

        public SozlesmeliPersonel(string id, string firstName, string lastName,byte gun,double gunluk) : base(id, firstName, lastName)
        {
            Gun = gun;
            Gunluk = gunluk;
        }
        

        public double MaasHesapla() => Math.Round((Gun * Gunluk),2);


        public override string AdSoyadGetir()
        {
            return $"{base.AdSoyadGetir()}\nÇalıştığı Gün Sayısı : {Gun}\nGünlük Ücreti : {Gunluk} TL\nAylık Maaşı : {MaasHesapla()} TL";
        }
    }
}
