using System;
using static Lesson1.Program;

namespace Lesson1
{
    internal partial class Program
    {
        public class Europa : IONU,ICorteEuropeaDeiDiritiUmani
        {
            public string NomePaese { get; set; }
            public void PaesiEuroZona()
            {
                Console.WriteLine($"Austria");
                Console.WriteLine($"Belgio");
                Console.WriteLine($"Cipro");
                Console.WriteLine($"Estonia");
                Console.WriteLine($"Finlandia");
                Console.WriteLine($"Francia");
                Console.WriteLine($"Germania");
                Console.WriteLine($"Grecia");
                Console.WriteLine($"Irlanda");
                Console.WriteLine($"Italia");
                Console.WriteLine($"Lettonia");
                Console.WriteLine($"Lituania");
                Console.WriteLine($"Lussemburgo");
                Console.WriteLine($"Malta");
                Console.WriteLine($"Paesi Bassi");
                Console.WriteLine($"Portogallo");
                Console.WriteLine($"Slovacchia");
                Console.WriteLine($"Slovenia");
                Console.WriteLine($"Spagna");
            }

            public void PaesiIONU()
            {
                {
                    Console.WriteLine($"Afghanistan");
                    Console.WriteLine($"Albania");
                    Console.WriteLine($"Algeria");
                    Console.WriteLine($"Andorra");
                    Console.WriteLine($"Angola");
                    Console.WriteLine($"Antigua");
                    Console.WriteLine($"Barbuda");
                    Console.WriteLine($"Arabia Saudita");
                    Console.WriteLine($"Argentina");
                    Console.WriteLine($"Armenia");
                    Console.WriteLine($"Australia");
                    Console.WriteLine($"Austria");
                    Console.WriteLine($"Azerbaigian");
                    Console.WriteLine($"Bahamas");
                    Console.WriteLine($"Bahrein");
                    Console.WriteLine($"Bangladesh");
                    Console.WriteLine($"Barbados");
                    Console.WriteLine($"Belize");
                    Console.WriteLine($"Benin");
                    Console.WriteLine($"Bhutan");
                    Console.WriteLine($"Bielorussia");
                    Console.WriteLine($"Birmania");
                    Console.WriteLine($"Bolivia");
                    Console.WriteLine($"Bosnia");
                    Console.WriteLine($"Erzegovina");
                    Console.WriteLine($"Botswana");
                    Console.WriteLine($"Brasile");
                    Console.WriteLine($"Brunei");
                    Console.WriteLine($"Burkina Faso");
                    Console.WriteLine($"Burundi");
                    Console.WriteLine($"Cambogia");
                    Console.WriteLine($"Camerun");
                    Console.WriteLine($"Canada");
                    Console.WriteLine($"Capo Verde");
                    Console.WriteLine($"Ciad");
                    Console.WriteLine($"Cile");
                    Console.WriteLine($"Cina");
                    Console.WriteLine($"Colombia");
                    Console.WriteLine($"Comore");
                    Console.WriteLine($"Corea del nord");
                    Console.WriteLine($"Corea del sud");
                    Console.WriteLine($"Costa Rica");
                    Console.WriteLine($"Costa d'Avorio");
                    Console.WriteLine($"Dominica");
                    Console.WriteLine($"Ecuador");
                    Console.WriteLine($"Egitto");
                    Console.WriteLine($"El Salvador");
                }
            }

            public void PaesiONU()
            {
                Console.WriteLine($"Afghanistan");
                Console.WriteLine($"Albania");
                Console.WriteLine($"Algeria");
                Console.WriteLine($"Andorra");
                Console.WriteLine($"Angola");
                Console.WriteLine($"Antigua");
                Console.WriteLine($"Barbuda");
                Console.WriteLine($"Arabia Saudita");
                Console.WriteLine($"Argentina");
                Console.WriteLine($"Armenia");
                Console.WriteLine($"Australia");
                Console.WriteLine($"Austria");
                Console.WriteLine($"Azerbaigian");
                Console.WriteLine($"Bahamas");
                Console.WriteLine($"Bahrein");
                Console.WriteLine($"Bangladesh");
                Console.WriteLine($"Barbados");
                Console.WriteLine($"Belize");
                Console.WriteLine($"Benin");
                Console.WriteLine($"Bhutan");
                Console.WriteLine($"Bielorussia");
                Console.WriteLine($"Birmania");
                Console.WriteLine($"Bolivia");
                Console.WriteLine($"Bosnia");
                Console.WriteLine($"Erzegovina");
                Console.WriteLine($"Botswana");
                Console.WriteLine($"Brasile");
                Console.WriteLine($"Brunei");
                Console.WriteLine($"Burkina Faso");
                Console.WriteLine($"Burundi");
                Console.WriteLine($"Cambogia");
                Console.WriteLine($"Camerun");
                Console.WriteLine($"Canada");
                Console.WriteLine($"Capo Verde");
                Console.WriteLine($"Ciad");
                Console.WriteLine($"Cile");
                Console.WriteLine($"Cina");
                Console.WriteLine($"Colombia");
                Console.WriteLine($"Comore");
                Console.WriteLine($"Corea del nord");
                Console.WriteLine($"Corea del sud");
                Console.WriteLine($"Costa Rica");
                Console.WriteLine($"Costa d'Avorio");
                Console.WriteLine($"Dominica");
                Console.WriteLine($"Ecuador");
                Console.WriteLine($"Egitto");
                Console.WriteLine($"El Salvador"); 
            }

            public void PaesiUe()
            {
                PaesiEuroZona();
                Console.WriteLine($"Bulgaria");
                Console.WriteLine($"Croazia");
                Console.WriteLine($"Danimarca");
                Console.WriteLine($"Polonia");
                Console.WriteLine($"Repubblica Ceca");
                Console.WriteLine($"Romania");
                Console.WriteLine($"Svezia");
                Console.WriteLine($"Ungheria");
            }

            public void check(Paesi paesi)
            {
               Console.WriteLine($"\nIl paese {paesi.Paese} viola i diritti umani: {paesi.viola}");
            }
        }
    }
}
