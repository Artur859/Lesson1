using System;

namespace Lesson1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Europa PaesiEuroZona = new Europa();
            Console.WriteLine("I paesi dell'Eurozona sono:");
            PaesiEuroZona.PaesiEuroZona();
            Console.WriteLine($"\n\nI paesi dell'UE sono:");
            Europa PaesiEuropei = new Europa();
            PaesiEuropei.PaesiUe();
            Console.WriteLine($"\n\n I paesi facenti parte dell'ONU sono:");
            Europa PaesiIONU = new Europa();
            PaesiEuropei.PaesiIONU();
            Console.WriteLine($"\n\nI paesi facenti parte sia dell'ONU che dell UE sono:");
            PaesiIONU.PaesiIONU();
            PaesiEuropei.PaesiUe();

            Paesi Angola = new Paesi();
            Angola.Paese = "Angola";
            Angola.viola = "si";
            Paesi Arabia_Saudita = new Paesi();
            Arabia_Saudita.Paese = "Arabia Saudita";
            Arabia_Saudita.viola = "si";
            Paesi Burundi = new Paesi();
            Burundi.Paese = "Burundi";
            Burundi.viola = "si";
            Paesi Cina = new Paesi();
            Cina.Paese = "Cina";
            Cina.viola = "si";
            Paesi Egitto = new Paesi();
            Egitto.Paese = "Egitto";
            Egitto.viola = "si";
            Europa europa = new Europa();
            europa.check(Arabia_Saudita);
            europa.check(Egitto);
            europa.check(Burundi);
            europa.check(Cina);
            
            PenaDiMorte penaDiMorte = new PenaDiMorte();
            penaDiMorte.Pena();

        }
    }
}
