using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models
{
    #region Students
    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student {
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
    #endregion

    #region StudentStatuses
    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
    #endregion

    #region Enrollments
    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }
    #endregion

    #region ScheduledClasses
    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass {
        //Build a custom property in the ScheduledClass partial that combines the StartDate, CourseName, and Location information.
        public string FullClass { get { return $"{StartDate.Date:d}, {Course.CourseName}, {Location}"; } }
    }
    #endregion

    #region ScheduledClassStatuses
    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
    #endregion

    #region Courses
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }
    #endregion
}
