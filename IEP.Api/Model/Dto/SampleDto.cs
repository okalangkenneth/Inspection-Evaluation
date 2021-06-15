using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEP.Api.Model.Dto
{
    public class SampleDto
    {
        public int Id { get; set; }
        public string ProduceName { get; set; }
        public string Description { get; set; }
        public DateTime Picked { get; set; }
    }
}
