using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo4.Shared;

namespace Demo4.Server.Service
{
    public interface IMyServer
    {
        MyServer UseConfig(Service.Helpers.MyServerConfig config);
        string GetTheKey();
        Task<object> GetEmployees();
    }

    public class MyServer
    {

        private readonly DatabaseContext _db;
        private readonly ILogger _log;
        private Service.Helpers.MyServerConfig _mySrvConfig;

        #region Server Startup
        public MyServer() { }

        public MyServer(DatabaseContext db, ILogger<MyServer> logger, Service.Helpers.MyServerConfig mySrvConfig)
        {
            logger.LogInformation("AppServer starting: Scoped");
            _log = logger;
            _db = db;
            _mySrvConfig = mySrvConfig;
        }

        internal MyServer UseConfig(Service.Helpers.MyServerConfig config)
        {
            Console.WriteLine($"The Key = {config.TheKey}");
            return this;
        }
        #endregion

        internal string GetTheKey()
        {
            return _mySrvConfig.TheKey;
        }




        internal List<ResponseCountries> GetCountries(RequestContries req)
        {
            List<ResponseCountries> countryList = new List<ResponseCountries>();

            for(int i=0; i<req.Countries; i++)
            {
                System.Threading.Thread.Sleep(req.Pause);
                countryList.Add(
                    new ResponseCountries()
                    {
                        CountryId = Faker.RandomNumber.Next(100, 999),
                        Country = Faker.Country.Name(),
                        CountryCode = Faker.Country.TwoLetterCode()
                    });                    
            }
            return countryList;
        }
    }
}
