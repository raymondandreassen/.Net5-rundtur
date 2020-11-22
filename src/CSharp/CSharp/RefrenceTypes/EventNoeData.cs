using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.RefrenceTypes
{
    public class NoeData
    {
        public event MyEventNoeData NoeDataRapporterer;
        public int BukerID { get; set; }

        public void NoeDataSenderEvent()
        {
            NoeDataRapporterer(this);
        }
    }


    public class HolderAvMasseData
    {
        public void Main()
        {
            List<NoeData> brukerliste = new;
            for (int i; i <= 10; i++)
            {
                NoeData obj = new { BrukerID = i;
            }
            obj.
            }







    }
}

}
