using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using IEP.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IEP.Api.Data
{
    public class SeedData
    {
        private static Faker _faker;
        private const int _maxJobs = 16;
        private const int _maxDepartments = 6;
        internal static async Task InitializeAsync(IServiceProvider services)
        {
            using var db = services.GetRequiredService<IEPApiContext>();
            {
                _faker = new Faker();

                // Fill the database only if Jobs and Department tables are empty 
                if (db.Department.Any() && db.Jobs.Any())
                {
                    return;
                }
                Random rnd = new();

                // Create departments
                var departments = new List<Department>();
                for (var i = 0; i < _maxDepartments; i++)
                {
                    var department = new Department
                    {
                        Name = _faker.Name.FindName(),
                        Jobs = new List<Job>()
                    };
                    departments.Add(department);
                }

                // Create Jobs
                var jobs = new List<Job>();
                for (var i = 0; i < _maxJobs; i++)
                {
                    var job = new Job
                    {
                        Title = _faker.Commerce.ProductName(),
                        InspectionDateTime = _faker.Date.Past(10, DateTime.Parse("2021-03-01")).Date,
                        Departments = new List<Department>()
                    };
                    jobs.Add(job);
                }
                //// Associate Jobs with Departments
                //// 1. Go over all the jobs and to each add a random department
                //foreach (var job in jobs)
                //{
                //    var department = departments[rnd.Next(_maxDepartments)];
                //    job.Departments.Add(department);
                //}
                //// 2. Go over all the departments and to each add some job
                //foreach (var department in departments)
                //{
                //    var job = jobs[rnd.Next(_maxJobs)];
                //    department.Jobs.Add(job);
                //}
                //await db.Jobs.AddRangeAsync(jobs);
                //await db.Department.AddRangeAsync(departments);

                await db.SaveChangesAsync();
            }
        }

    }
}
