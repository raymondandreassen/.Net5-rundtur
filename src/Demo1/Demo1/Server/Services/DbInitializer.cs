using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Shared.Model;

namespace Demo1.Server.Services
{
    public interface IDbInitializer
    {
        /// <summary>
        /// Applies any pending migrations for the context to the database.
        /// Will create the database if it does not already exist.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Adds some default values to the Db
        /// </summary>
        void SeedData();
    }

    public class DbInitializer : IDbInitializer
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public DbInitializer(IServiceScopeFactory scopeFactory)
        {
            this._scopeFactory = scopeFactory;
        }

        public void Initialize()
        {
            using (var serviceScope = _scopeFactory.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<DbWorker>())
                {
                    context.Database.Migrate();
                }
            }
        }

        public void SeedData()
        {
            using (var serviceScope = _scopeFactory.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<DbWorker>())
                {
                    if(context.Department.Count() > 0)
                    {   // Slett alt, Department
                        context.Department.RemoveRange(context.Department.Where(c => c.DepartmentID > 0));
                        context.SaveChanges();
                    }

                    // Seed initial data
                    for (int i = 1000; i <= 1100; i++)
                    {   // Create 100 fake departments
                        context.Department.Add(new Department() { DepartmentID = i, DepartmentName = Faker.Company.Name(), DepartmentInfo = Faker.Lorem.Sentence(100) });
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}