﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEP.Api.Model.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime InspectionDateTime { get; set; }


        public string LocationId { get; set; }
        public Location Location { get; set; }
        public string DepartmentId { get; set; }
        public Department Department { get; set; }

        public string InspectorId { get; set; }
        public Inspector Inspector { get; set; }

        public ICollection<Sample> Samples { get; set; }

    }
}