using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Server.Services
{
    /// <summary>
    /// Transient: 
    /// Ny for hver eneste request.
    /// </summary>
    public class TransientService
    {
        internal TransientService()
        {
            Console.WriteLine("Instansierer TransientService");
        }

        internal DateTime GetDate()
        {
            return DateTime.Now;
        }




    }
}
