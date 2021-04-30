using ConsoleAppAdapater.Models;
using ConsoleAppAdapater.Models.Interfaces;

namespace ConsoleAppAdapater
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            IWerknemer werknemer1 = new Werknemer("Kees", "van Kralingen", 2500);
            IWerknemer werknemer2 = new Werknemer("Karel", "van Dijk", 2800);
            IWerknemer werknemer3 = new Werknemer("Pieter", "de Boer", 2500);

            WerknemerSysteem werknemerSysteem = new WerknemerSysteem();
            werknemerSysteem.VoegToeWerknemer(werknemer1);
            werknemerSysteem.VoegToeWerknemer(werknemer2);
            werknemerSysteem.VoegToeWerknemer(werknemer3);

            Employee employee1 = new Employee("Sam", "Potter", 3000);

            werknemerSysteem.VoegToeWerknemer(new EmployeeAdapter(employee1));

            werknemerSysteem.UitBetalen();
        }
    }
}
