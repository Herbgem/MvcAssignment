using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAssignment.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Studnet { get; set; }
    }
}