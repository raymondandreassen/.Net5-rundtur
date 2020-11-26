using System;
using System.Collections.Generic;
using System.Text;

namespace Demo3.Shared
{
    public class TestMessageResponse
    {
        public string navn;
        public string svar;
        public string[] noe;
        public List<string> baretull;

        public override string ToString()
        {
            return $"Navn : {navn}, {noe.ToString()}";
        }
    }
}


