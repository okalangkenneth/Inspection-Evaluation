using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEP.Api.Model.Entities;
using IEP.Core.Entities;

namespace IEP.Core
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Job> Jobs { get; set; }
        public ICollection<Inspector> Inspectors { get; set; }
        public ICollection<Sample> Samples { get; set; }


    }
}
