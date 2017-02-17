using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Grade? Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation property
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }

    public enum Grade
    {
        A,
        B,
        C,
        F
    }
}