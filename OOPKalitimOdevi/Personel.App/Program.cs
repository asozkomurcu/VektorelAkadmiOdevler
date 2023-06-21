using OOPKalitimOdevi;
using System.Threading.Channels;

namespace Personel.App
{
    class Program
    {
        static void Main()
        {
            KadroluPersonel kadroluPersomel = new KadroluPersonel();
            kadroluPersomel.PersonType = "kadrolu";
            kadroluPersomel.Id = "154";
            kadroluPersomel.FirstName = "  mehmet ";
            kadroluPersomel.LastName = "  ağa  ";
            kadroluPersomel.Rapor = 7;
            kadroluPersomel.Aylik = 10000;

            SozlesmeliPersonel sozlesmeliPersonel = new SozlesmeliPersonel("sözleşmeli","23", "ali", "yazar", 21, 285.5);

            StajyerPersonel stajyerPersonel = new StajyerPersonel
            {
                PersonType = "stajyer",
                Id = "3719",
                FirstName = "veli",
                LastName = "bozar",
                Saat = 153,
                Saatlik = 37.5
            };


            Console.WriteLine(kadroluPersomel.AdSoyadGetir());

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(sozlesmeliPersonel.AdSoyadGetir());

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(stajyerPersonel.AdSoyadGetir());

            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }

        
    }
}