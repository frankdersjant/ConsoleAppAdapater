using ConsoleAppAdapater.Models.Interfaces;
using System.Collections.Generic;

namespace ConsoleAppAdapater.Models
{
    public class WerknemerSysteem
    {
        private List<IWerknemer> _werknemers;

        public WerknemerSysteem()
        {
            _werknemers = new List<IWerknemer>();
        }
       
        public void VoegToeWerknemer(IWerknemer werknemer)
        {
            _werknemers.Add(werknemer);
        }

        public void UitBetalen()
        {
            foreach (IWerknemer werknemer in _werknemers)
            {
                werknemer.BetaalSalaris();
            }
        }
    }
}
