using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.Courses;

namespace UniversityManagementSystem.Application.ApplicationServices.CourseManagement.Courses
{
    public interface ICourseServiceAsync
    {
        Task<BaseResponse<IEnumerable<CourseViewModel>>> GetAllCoursesAsync();
        Task<BaseResponse<IEnumerable<CourseViewModel>>> GetAllCoursesByCourseCategoryId(int courseCategoryId);
        Task<BaseResponse<CourseViewModel>> CreateCourseAsync(CourseInputModel courseToCreate);
        Task<BaseResponse<CourseViewModel>> UpdateCourseAsync(CourseUpdateModel courseToUpdate);
        Task<BaseResponse<CourseViewModel>> GetCourseByIdAsync(int courseId);
        Task<BaseResponse<CourseViewModel>> DeleteCourseAsync(int courseId);

    }
}
 