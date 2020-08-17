using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputanVidely.Models;
using System.ComponentModel.DataAnnotations;

namespace ComputanVidely.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18IfAMember]
        public DateTime? BirthDate { get; set; }
    }
}