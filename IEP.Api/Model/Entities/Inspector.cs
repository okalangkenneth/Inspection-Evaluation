using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IEP.Core;
using IEP.Core.Entities;

namespace IEP.Api.Model.Entities
{
    public class Inspector
    {
        public int Id { get; set; }

        public string Avatar { get; set; }
        public string FirstName { get; set; }
        

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Email { get; set; }


        public ICollection<Sample> Samples { get; set; }

       




    }
}
