using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Data.Models.CourseManagement.Courses
{
    public class CourseUpdateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseCategoryId { get; set; }
    }
}
