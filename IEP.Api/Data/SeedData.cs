using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using IEP.Api.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IEP.Api.Data
{
    public static class SeedData
    {
        
        public static async Task InitAsync(IServiceProvider services)
        {
            using var db = new IEPApiContext(services.GetRequiredService<DbContextOptions<IEPApiContext>>());
            if (!await db.Client.AnyAsync()) return;

            var faker = new Faker("sv");
            var clients = new List<Client>();


            for (int i = 0; i < 50; i++)
            {

                clients.Add(new Model.Entities.Client
                {
                    CompanyName = faker.Company.CompanyName() + faker.Random.Word(),

                    JobLocation = new JobLocation()
                    {
                        Address = faker.Address.StreetAddress(),
                        CityTown = faker.Address.City()

                    },
                    Inspectors = new Inspector[]
                    {
                        new Inspector
                        {
                            FirstName=faker.Name.FirstName(),
                            LastName = faker.Name.LastName(),
                            Email=faker.Internet.Email()
                        }
                    },
                    Jobs = new Job[]
                    {
                        new Job
                        {
                         Title = faker.Commerce.Department(),
                         InspectionDateTime = DateTime.Now.AddDays(faker.Random.Int(-20, 20))
                        }
                    },
                    Samples = new Sample[]
                    {
                       new Sample
                       {
                       ProduceName=faker.Commerce.ProductName()
                       },
                    }

                });

            }
            db.AddRange(clients);
            await db.SaveChangesAsync();

        }
    }

} 


   




