using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEP.Api.Model.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public int JobLocationId { get; set; }
        public JobLocation JobLocation { get; set; }

        
        public ICollection<Inspector>Inspectors { get; set; }

        public ICollection<Job> Jobs { get; set; }
        public ICollection<Sample> Samples { get; set; }



    }
}
