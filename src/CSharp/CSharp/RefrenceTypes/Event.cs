using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.RefrenceTypes
{
    class ClassWithEvent
    {
        public event EventHandler SomeThingHappened;
        protected virtual void OnSomeThingHappened(EventArgs e)
        {
            EventHandler handler = SomeThingHappened;
            handler?.Invoke(this, e);
        }

        // Resten av implementasjonen av klassen
    }


    //public class OnSomeThingHappenedEventArgs : EventArgs
    //{   // Vi trenger noe å sende inn, eller bare bruke f.eks. en string, int, etc. 
    //    public int EtTall { get; set; }
    //    public string EnString { get; set; }
    //}


    class RunThis
    {
        void RunThisEventThing()
        {
            // Instansiere og "koble opp"
            var c = new ClassWithEvent();
            c.SomeThingHappened += ClassWithEvent_SomeThingHappened; ;

            
        }

        // "Motta"
        private void ClassWithEvent_SomeThingHappened(object sender, EventArgs e)
        {
        }
    }


}
