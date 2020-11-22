using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.RefrenceTypes
{
    class Test
    {
        delegate void TestDelegate(string s);
        static void M(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            // Koble delegate til metoder, alt på sin egen "metode"
            TestDelegate testDelA = new TestDelegate(M);                            // c# v1
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };  // c# v2
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };               // c# v3

            // Invoke
            testDelA("Hei, dette var slik man gjorde det i v1.");
            testDelB("Versjon 2 kom med anonyme funksjoner.");
            testDelC("Versjon 3 kom med lamda uttrykk.");
        }
    }
    /* Output:
        Hei, dette var slik man gjorde det i v1.
        Versjon 2 kom med anonyme funksjoner.
        Versjon 3 kom med lamda uttrykk.
    */
}
