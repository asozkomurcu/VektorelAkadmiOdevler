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

        public SozlesmeliPersonel(string personType, string id, string firstName, string lastName,byte gun,double gunluk) : base(personType,id, firstName, lastName)
        {
            Gun = gun;
            Gunluk = gunluk;
        }
        

        public double MaasHesapla() => Math.Round((Gun * Gunluk),2);


        public override string AdSoyadGetir()
        {
            return $"{base.AdSoyadGetir()}\nÇalıştığı Gün Sayısı\t: {Gun}\nGünlük Ücreti\t\t: {Gunluk} TL\nAylık Maaşı\t\t: {MaasHesapla()} TL";
        }
    }
}
