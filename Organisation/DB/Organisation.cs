using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Organisation.DB
{
    public class Organisation
    {
        [Key]
        //public int OrganisationId { get; set; }
        public string OrganisationNumber { get; set; }
        public string OrganisationName { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? Town { get; set; }
        public string Postcode { get; set; }




    }
}
