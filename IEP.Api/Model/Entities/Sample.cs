using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEP.Api.Model.Entities
{
    public class Sample
    {
        public int Id { get; set; }
        public string ProduceName { get; set; }


        public int InspectorId { get; set; }
        public Inspector Inspector { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
