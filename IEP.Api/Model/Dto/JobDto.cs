using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEP.Api.Model.Dto
{
    public class JobDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime InspectionDateTime { get; set; }
    }
}
