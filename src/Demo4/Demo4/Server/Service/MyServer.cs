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

        private readonly DatabaseContext db;
        private readonly ILogger logger;
        private Service.Helpers.MyServerConfig _mySrvConfig;

        #region Server Startup
        public MyServer() { }

        public MyServer(DatabaseContext db, ILogger<MyServer> logger, Service.Helpers.MyServerConfig mySrvConfig)
        {
            logger.LogInformation("AppServer starting: Scoped");
            this.logger = logger;
            this.db = db;
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

        internal async Task<int?> NewUser(AppUser appuser)
        {
            try
            {
                appuser.Modified = DateTime.Now;
                appuser.UserNumber = Faker.RandomNumber.Next(1000, 1000000);    // Dette er det dummeste jeg har laget !

                db.User.Add(appuser);             

                await db.SaveChangesAsync();
                AppUser user = db.User.Where(c => c.UserID.Equals(appuser.UserID)).SingleOrDefault();
                return user.UserNumber;
            }
            catch (Exception exc)
            {
                logger.LogError("Error on NewUser", exc);
            }
            return null;
        }

        internal async Task<AppUser> SetUser(AppUser appuser)
        {
            db.User.Update(appuser);
            await db.SaveChangesAsync();
            return appuser;
        }
    }
}
