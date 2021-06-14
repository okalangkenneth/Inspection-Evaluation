using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEP.Api.Model.Entities;

namespace IEP.Core.Entities
{
    public class Sample
    {
        public int Id { get; set; }
        public string ProduceName { get; set; }
        public string Description { get; set; }
        public DateTime Picked { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set;}
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int InspectId { get; set; }
        public Inspector Inspector { get; set; }

        

        
       

       
        


    }
}
