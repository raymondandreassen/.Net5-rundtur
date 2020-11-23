using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.RefrenceTypes
{
    public class Ansatt : Bruker
    {
        string ansattkode;
        string avdeling;

        public string Ansattkode(string kode) => ansattkode = kode;

        public string Avdeling
        {
            get => avdeling;
            set => avdeling = value;
        }
    }
}
