using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Server.Services
{


    /// <summary>
    /// Singleton: 
    /// Den samme hver gang, for alle brukere. 
    /// </summary>
    public class SingeltonService 
    {
        internal SingeltonService()
        {
            Console.WriteLine("Instansierer SingeltonService");
        }


    }
}
