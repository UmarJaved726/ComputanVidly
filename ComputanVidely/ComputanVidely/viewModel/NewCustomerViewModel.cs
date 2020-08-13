using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputanVidely.Models;

namespace ComputanVidely.viewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}