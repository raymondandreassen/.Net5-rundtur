using Demo4.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo4.Server.Service.Helpers
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
                using (var context = serviceScope.ServiceProvider.GetService< DatabaseContext> ())
                {
                    context.Database.Migrate();
                }
            }
        }

        public void SeedData()
        {
            using (var serviceScope = _scopeFactory.CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService< DatabaseContext> ())
                {
                    if (context.AnswerAlteratives.Count() > 0)
                    {   // Slett alt
                        context.AnswerAlteratives.RemoveRange(context.AnswerAlteratives);
                        context.SaveChanges();
                    }
                    if (context.Questions.Count() > 0)
                    {   // Slett alt
                        context.Questions.RemoveRange(context.Questions);
                        context.SaveChanges();
                    }
                    if (context.Questionares.Count() > 0)
                    {   // Slett alt
                        context.Questionares.RemoveRange(context.Questionares);
                        context.SaveChanges();
                    }


                    // Seed initial data
                    for (int i = 1; i <= 20; i++)
                    {   // Create fake Questionares
                        context.Questionares.Add(new Questionare() { 
                            QuestId = i,
                            DisplayName = Faker.Lorem.Paragraph(),
                            StartDate = DateTime.Now.AddDays(Faker.RandomNumber.Next(1, 200)),
                            EndDate = DateTime.Now.AddDays(Faker.RandomNumber.Next(200, 300))
                        });
                    }
                    context.SaveChanges();

                    List<Questionare> qList = context.Questionares.ToList<Questionare>();
                    foreach (Questionare q in qList)
                    {
                        for (int i = 1; i <= 10; i++)
                        {   // Create  fake 
                            q.Questions.Add(new Question()
                            {
                                QuestionString = Faker.Lorem.Paragraph(),
                                QuestionDescription = Faker.Lorem.Paragraph()
                            });
                        }
                    }
                    context.SaveChanges();


                    List<Question> qList2 = context.Questions.ToList<Question>();
                    foreach (Question q in qList2)
                    {
                        for (int i = 1; i <= 4; i++)
                        {   // Create fake 
                            q.AnswerAlternatives.Add(new AnswerAlteratives()
                            {
                                Answer = Faker.Lorem.Paragraph()
                            });
                        }
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
