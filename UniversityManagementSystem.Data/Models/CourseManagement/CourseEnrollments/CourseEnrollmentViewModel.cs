﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Common;

namespace UniversityManagementSystem.Data.Models.CourseManagement.CourseEnrollments
{
    public class CourseEnrollmentViewModel : AuditFields
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentNumber { get; set; }
        public int CourseId { get; set; }
        public string StudentFullName { get; set; }
        public string CourseName { get; set; }
        public string CourseCategory { get; set; }
    }
}
