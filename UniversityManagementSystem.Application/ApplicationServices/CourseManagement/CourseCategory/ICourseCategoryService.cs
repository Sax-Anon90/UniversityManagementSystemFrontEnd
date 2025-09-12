using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.CourseCategory;

namespace UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseCategory
{
    public interface ICourseCategoryService
    {
        Task<BaseResponse<IEnumerable<CourseCategoryViewModel>>> GetAllCourseCategoriesAsync();
        Task<BaseResponse<CourseCategoryViewModel>> CreateCourseCategoryAsync(CourseCategoryInputModel courseCategoryToCreate);
        Task<BaseResponse<CourseCategoryViewModel>> UpdateCourseCategoryAsync(CourseCategoryUpdateModel courseCategoryToUpdate);
    }
}
