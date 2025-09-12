using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Common;

namespace UniversityManagementSystem.Data.Models.CourseManagement.Courses
{
    public class CourseViewModel : AuditFields
    {
        public int Id { get; set; }
        public int CourseCategoryId { get; set; }
        public string Name { get; set; }
        public string CourseCategory { get; set; }
        public bool IsActive { get; set; }
    }
}
