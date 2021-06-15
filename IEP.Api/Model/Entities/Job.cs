using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IEP.Api.Model.Entities
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public DateTime InspectionDateTime { get; set; }


        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int InspectorId { get; set; }
        public Inspector Inspector { get; set; }

        public ICollection<Sample> Samples { get; set; }

    }
}
