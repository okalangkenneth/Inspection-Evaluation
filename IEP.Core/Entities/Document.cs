using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEP.Api.Model.Entities;

namespace IEP.Core.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime UploadTime { get; set; }

        public int? QualityReportId { get; set; }
        public QualityReport QualityReport { get; set; }

        
       
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}
