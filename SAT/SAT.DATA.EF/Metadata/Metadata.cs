using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models
{
    #region Students
    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [StringLength(15)]
        public string? Major { get; set; }

        [StringLength(50)]
        public string? Address { get; set; }

        [StringLength(25)]
        public string? City { get; set; }

        [StringLength(2)]
        public string? State { get; set; }

        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }

        [StringLength(13)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [StringLength(60)]
        public string Email { get; set; } = null!;

        [StringLength(100)]
        public string? PhotoUrl { get; set; }

        [Required]
        public int Ssid { get; set; }
    }
    #endregion

    #region StudentStatuses
    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }

        [StringLength(30)]
        [Display(Name = "Student Status")]
        public string Ssname { get; set; } = null!;
        [Required]
        [StringLength(250)]
        [Display(Name ="Description")]
        [DataType(DataType.MultilineText)]
        public string? Ssdescription { get; set; }
    }
    #endregion

    #region Enrollments
    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }

        [Required]
        [Display(Name ="Student Id")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name ="Class Id")]
        public int ScheduledClassId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
    #endregion

    #region ScheduledClasses
    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name ="Course Id")]
        public int CourseId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [StringLength(40)]
        [Required]
        [Display(Name ="Instructor Name")]
        public string InstructorName { get; set; } = null!;

        [Required]
        [StringLength(40)]

        public string Location { get; set; } = null!;

        [Required]
        public int Scsid { get; set; }
    }
    #endregion

    #region ScheduledClassStatuses
    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Scheduled Class")]
        public string Scsname { get; set; } = null!;
    }
    #endregion

    #region Courses
    public class CourseMetadata
    {
        public int CourseId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Course Name")]
        public string CourseName { get; set; } = null!;

        [Required]
        [Display(Name ="Description")]
        public string CourseDescription { get; set; } = null!;

        [Required]
        [Display(Name ="Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string? Curriculum { get; set; }

        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; }

        [Required]
        [Display(Name ="Active")]
        public bool IsActive { get; set; }
    }
    #endregion

}
