using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.CourseEnrollments;

namespace UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseEnrollments
{
    public interface ICourseEnrollmentServiceAsync
    {
        Task<BaseResponse<IEnumerable<CourseEnrollmentViewModel>>> GetAllStudentCourseEnrollmentsByStudentIdAsync(int studentId);
        Task<BaseResponse<CourseEnrollmentViewModel>> CreateCourseEnrollmentAsync(CourseEnrollmentInputModel courseEnrollmentToCreate);
        Task<BaseResponse<CourseEnrollmentViewModel>> DeleteCourseEnrollmentAsync(int courseEnrollmentId);
    }
}
