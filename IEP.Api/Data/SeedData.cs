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
    public class SeedData//Not Static Class
    {
        private readonly IEPApiContext db;

        public SeedData(IEPApiContext db)
        {
            this.db = db;
        }
        
        public void Seed(IEPApiContext db)//Constructor not Async method
        {
            //using var db = new IEPApiContext(services.GetRequiredService<DbContextOptions<IEPApiContext>>());
            if ( db.Client.Any()) return;

            var faker = new Faker("sv");
            var clients = new List<Client>();
            var departments = new List<Department>();


            for (int i = 0; i < 50; i++)
            {
                //New Department for referencing with Client
                var department = new Department() {
                    Name = faker.Commerce.Department(),
                    };
                departments.Add(department);

                //Creating Inspector outside Client
                var inspector = new Inspector
                {
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    Email = faker.Internet.Email()
                };

                var client = new Client() 
                //db.Client.Add(new Model.Entities.Client
                {
                    CompanyName = faker.Company.CompanyName() + faker.Random.Word(),
                    
                    JobLocation = new JobLocation()
                    {
                        Address = faker.Address.StreetAddress(),
                        CityTown = faker.Address.City()

                    },
                    Inspectors = new Inspector[] {inspector},
                    //{
                    //    new Inspector
                    //    {
                    //        FirstName=faker.Name.FirstName(),
                    //        LastName = faker.Name.LastName(),
                    //        Email=faker.Internet.Email()
                    //    }
                    //},
                    Jobs = new Job[]
                    {
                        new Job
                        {
                         Title = faker.Commerce.Department(),
                         InspectionDateTime = DateTime.Now.AddDays(faker.Random.Int(-20, 20)),
                         Department = department
                        }
                    },
                    Samples = new Sample[]
                    {
                       new Sample
                       {
                        ProduceName=faker.Commerce.ProductName(),
                        Department = department,
                        Inspector = inspector
                       },
                    }

                };
                clients.Add(client);
            }
            db.Department.AddRange(departments);
            db.Client.AddRange(clients);    
            db.SaveChanges();

        }
    }

} 


   




