using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoddadyApiImplementation.Domains.Responses
{
    public class CartFeeResponse
    {
        public decimal Total { get; set; }
        public int Icann { get; set; }
    }
}
