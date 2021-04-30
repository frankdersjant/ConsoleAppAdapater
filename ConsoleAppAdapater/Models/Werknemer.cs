using ConsoleAppAdapater.Models.Interfaces;
using System;

namespace ConsoleAppAdapater.Models
{
    public class Werknemer : IWerknemer
    {
        public string achterNaam { get; private set; }

        public string VoorNaam { get; private set; }

        public double salaris { get; private set; }

        public Werknemer(string achterNaam, string voorNaam, double salaris)
        {
            this.achterNaam = achterNaam;
            VoorNaam = voorNaam;
            this.salaris = salaris;
        }
        public void BetaalSalaris()
        {
            Console.WriteLine("Paying");
        }

        public string VolledigeNaam()
        {
            return achterNaam + " "+ VoorNaam; 
        }
    }
}
