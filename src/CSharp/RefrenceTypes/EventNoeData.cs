using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.RefrenceTypes
{
    internal class NoeData
    {
        internal event RunClass.MyEventNoeData NoeDataRapporterer;

        internal int BrukerID { get; set; }

        internal void NoeDataSenderEvent()
        {
            NoeDataRapporterer(this);
        }
    }


    public class RunClass
    {
        internal delegate void MyEventNoeData(NoeData obj);

        public void Main()
        {
            List<NoeData> brukerliste = new List<NoeData>();
            for (int i = 0; i <= 10; i++)
            {
                NoeData obj = new NoeData() { BrukerID = i };
                obj.NoeDataRapporterer += Obj_NoeDataRapporterer;
            }

            // Bare for å teste, vi lar nr7 sende
            brukerliste[7].NoeDataSenderEvent();
        }

        private void Obj_NoeDataRapporterer(NoeData obj)
        {
            // Behandle det objektet som rapporterer. 
            // obj vil i testen referere til nr7            
        }
    }
}


