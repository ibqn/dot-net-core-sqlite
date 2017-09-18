using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ContosoUniversity.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters.")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
