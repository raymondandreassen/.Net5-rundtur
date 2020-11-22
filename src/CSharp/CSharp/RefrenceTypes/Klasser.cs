using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.RefrenceTypes
{
    public class Bruker
    {
        string brukernavn;

        // Vanlig Constructor
        public Bruker()
        { }

        // Constructor med innhold
        public Bruker(string brukernavn)
        {   // Kanskje ikke helt innafor å ha like navn på property og parameter
            this.brukernavn = brukernavn;
        }

        // Property som settes under init, slik
        // new Bruker()
        // {
        // 		BrukerId = 12345;
        // }

        // Med init, så gjør vi den read-only. 
        // Trenger ikke å sette gjennom constructor
        public int BrukerId { get; init; }

        // Vanlig 
        public string Brukernavn1
        {
            get { return brukernavn; }
            set
            {
                brukernavn = value;
            }
        }

        // Forenklet
        public string Brukernavn2 { get; set; }

        // void metode
        public void DoSomething()
        {

        }

        // metode som returnerer
        public string DoSomethingElse()
        {
            return ".....";
        }
    }
}
