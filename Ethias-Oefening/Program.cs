using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Ethias_Oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ETHIAS - GROET
             * 
             * Voorzie een programma dat door de verzekeringsmaatschappij
             * Ethias gebruikt kan worden om klanten te registreren.
             * 
             * Maak één variabele aan, genaamd groet
             *  - Zorg er voor dat je groet meerdere regels lang is
             *  - Druk de groet af, zodra het programma start
             * 
               */
            string groet = " ---------------------------------------------- \n " +
                           "|                                             | \n " +
                           "|  Welkom Bij Ethias Verzekeringsmaatschapij  | \n " +
                           "|                                             | \n " +
                           " ----------------------------------------------";
            Console.WriteLine(groet);
            



            /*
             * ETHIAS - REGISTRATIE FORMULIER
             * Nadat de welkomsgroet getoond is, vraagt het programma om gegevens van de klant in te geven voor registratie
             * 
             * Maak een variabele voor elk van de volgende klantengegevens:
             *  - Voornaam
             *  - Achternaam
             *  - Leeftijd
             *  - IsMan (waar of niet waar)
             *  - Telefoonnummer
             */

            Console.WriteLine("Wat is u voornaam?");
            string Voornaam = Console.ReadLine();

            Console.WriteLine("Wat is u achternaam?");
            string Achternaam = Console.ReadLine();

            Console.WriteLine("Hoe oud bent u?");
            string leeftijdInTekst = Console.ReadLine();
            int Leeftijd = Convert.ToInt32(leeftijdInTekst);

            Console.WriteLine("Bent u een man? Y/N");
            string AntwoordOpVraag = Console.ReadLine();
            bool IsMan = "Y" == AntwoordOpVraag;


            Console.WriteLine("Wat is u telefoonnummer?");
            string Telefoonnummer = Console.ReadLine();




            /*
             * ETHIAS - VERSLAG PRINTEN
             * Nadat het programma alle gegevens heeft ontvangen van de klant
             * wordt er een samenvatting afgedrukt in de console.
             * 
             * Gebruik string interpolatie om de variabelen te injecteren in een 
             * samenvatting. Zorg er voor dat je samenvatting uitlijning bevat.
             */
            Console.WriteLine($"De gegevens van de klant: \n" +
                              $"Volledige naam: {Voornaam} {Achternaam}\n" +
                              $"Leeftijd: {Leeftijd}\n" +
                              $"Is geslacht man? {IsMan}\n" +
                              $"Telefoonnummer: {Telefoonnummer}");
            Console.ReadLine();





            /*
             * ETHIAS - TryParse
             * Pas je Ethias registratie programma aan, zodat het niet meer kan
             * crashen wanneer er ongeldige input wordt ingegeven.
             * 
             * Gebruik TryParse om je waardes te converteren.
             */


        }
    }
}
