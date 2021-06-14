using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IEP.Core;
using IEP.Core.Entities;

namespace IEP.Api.Model.Entities
{
    public class Inspector
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string DepartmentId { get; set; }
        public Department Department { get; set; }

        public int JobId {get;set;}
        public Job Job { get; set; }

        public ICollection<Sample> Samples { get; set; }

    }
}
