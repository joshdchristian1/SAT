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
    public partial class Student { }
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
    public partial class ScheduledClass { }
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
