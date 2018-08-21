using GoddadyApiImplementation.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Requests
{
    public class CountryDetailRetrieve
    {
        [Required]
        public int MarketId { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }
    }
}
