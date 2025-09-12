using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseEnrollments;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.CourseEnrollments;

namespace UniversityManagementSystem.ApiLayer.ApiServices.CourseManagement.CourseEnrollments
{
    public class CourseEnrollmentServiceAsync : ICourseEnrollmentServiceAsync
    {
        public CourseEnrollmentServiceAsync()
        {
            
        }
        public Task<BaseResponse<CourseEnrollmentViewModel>> CreateCourseEnrollmentAsync(CourseEnrollmentInputModel courseEnrollmentToCreate)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<CourseEnrollmentViewModel>> DeleteCourseEnrollmentAsync(int courseEnrollmentId)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<CourseEnrollmentViewModel>>> GetAllStudentCourseEnrollmentsByStudentIdAsync(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
