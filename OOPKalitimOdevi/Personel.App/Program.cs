using OOPKalitimOdevi;
using System.Threading.Channels;

namespace Personel.App
{
    class Program
    {
        static void Main()
        {
            KadroluPersonel kadroluPersomel = new KadroluPersonel();
            kadroluPersomel.Id = "154";
            kadroluPersomel.FirstName = "  abidin samet ";
            kadroluPersomel.LastName = "  özkömürcü  ";
            kadroluPersomel.Rapor = 7;
            kadroluPersomel.Aylik = 10000;

            SozlesmeliPersonel sozlesmeliPersonel = new SozlesmeliPersonel("23", "ali", "yazar", 21, 285.5);

            StajyerPersonel stajyerPersonel = new StajyerPersonel
            {
                Id = "3719",
                FirstName = "veli",
                LastName = "bozar",
                Saat = 153,
                Saatlik = 37.5
            };


            Console.WriteLine(kadroluPersomel.AdSoyadGetir());

            Console.WriteLine(new string('*', 25));

            Console.WriteLine(sozlesmeliPersonel.AdSoyadGetir());

            Console.WriteLine(new string('*', 25));

            Console.WriteLine(stajyerPersonel.AdSoyadGetir());

            Console.WriteLine(new string('*', 25));

            Console.ReadKey();
        }

        
    }
}