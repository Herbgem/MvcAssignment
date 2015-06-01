using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAssignment.Models
{
    public class UserProfile
    {
        public int USerProfileId { get; set; }

        [Required]
        [StringLength(50, MinimumLength=3, ErrorMessage="User Name must be longer than 3 characters")]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, MinimumLength=3, ErrorMessage="Password must be longer than 3 characters")]
        public string Password { get; set; }
    }
}