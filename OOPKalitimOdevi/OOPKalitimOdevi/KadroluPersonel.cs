using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdevi
{
    public class KadroluPersonel : PersonBase, IMaasHesapla
    {
        public double Aylik { get; set; }
        public byte Rapor { get; set; }

        public KadroluPersonel(string id, string firstName, string lastName, double aylik,byte rapor) : base(id, firstName, lastName)
        {
            Aylik = aylik;
            Rapor = rapor;
        }

        public KadroluPersonel()
        {
        }

        
        public double MaasHesapla()
        {
            
            if (Rapor <= 5)
            {
                return Aylik;
            }
            else if (Rapor > 30) 
            {
                return Aylik = 0;
            }
            else
            {
                return Math.Round((Aylik-(Aylik/30)*Rapor),2);
            }
        }

        public string HataliRapor()
        {

            return $"\tRapor süresi 30 günden fazla olduğu için (Girilen gün sayısı : {Rapor}) \n\tMaaş değeri 0 (sıfır) olarak güncellenmiştir. Lütfen rapor süresini kontrol ediniz.";

            
        }

        public string AylikMaas()
        {
            if (Rapor > 30)
            {
                return $"0 TL\n{HataliRapor()}";
            }
            else 
            {
                return $"{MaasHesapla().ToString()} TL";
            }
        }
        public override string AdSoyadGetir()
        {
            return $"{base.AdSoyadGetir()}\nRaporlu Gün Sayısı : {Rapor}\nAylık Maaşı : {AylikMaas()} ";
        }

        
    }

    
}
