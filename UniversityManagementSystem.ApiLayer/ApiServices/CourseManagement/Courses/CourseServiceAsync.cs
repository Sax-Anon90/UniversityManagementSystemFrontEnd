using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.ApiLayer.BaseApiServiceConfig;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.Courses;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.Courses;

namespace UniversityManagementSystem.ApiLayer.ApiServices.CourseManagement.Courses
{
    public class CourseServiceAsync : ICourseServiceAsync
    {
        private readonly ApiServiceConfig _apiServiceConfig;
        public CourseServiceAsync(ApiServiceConfig _apiServiceConfig)
        {
            this._apiServiceConfig = _apiServiceConfig;
        }
        public async Task<BaseResponse<CourseViewModel>> CreateCourseAsync(CourseInputModel courseToCreate)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEndpoint}")
                                                                  .AllowAnyHttpStatus()
                                                                  .PostJsonAsync(new
                                                                  {
                                                                      courseToCreate = courseToCreate
                                                                  })
                                                                  .ReceiveJson<BaseResponse<CourseViewModel>>();
            return response;
        }

        public async Task<BaseResponse<CourseViewModel>> DeleteCourseAsync(int courseId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEndpoint}/{courseId}")
                                                                 .AllowAnyHttpStatus()
                                                                 .DeleteAsync()
                                                                 .ReceiveJson<BaseResponse<CourseViewModel>>();
            return response;
        }

        public async Task<BaseResponse<IEnumerable<CourseViewModel>>> GetAllCoursesAsync()
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEndpoint}")
                                                                  .AllowAnyHttpStatus()
                                                                  .GetJsonAsync<BaseResponse<IEnumerable<CourseViewModel>>>();
            return response;
        }

        public async Task<BaseResponse<IEnumerable<CourseViewModel>>> GetAllCoursesByCourseCategoryId(int courseCategoryId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEndpoint}/courseCategory/{courseCategoryId}")
                                                                   .AllowAnyHttpStatus()
                                                                   .GetJsonAsync<BaseResponse<IEnumerable<CourseViewModel>>>();
            return response;
        }

        public async Task<BaseResponse<CourseViewModel>> GetCourseByIdAsync(int courseId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEndpoint}/{courseId}")
                                                                  .AllowAnyHttpStatus()
                                                                  .GetJsonAsync<BaseResponse<CourseViewModel>>();
            return response;
        }

        public async Task<BaseResponse<CourseViewModel>> UpdateCourseAsync(CourseUpdateModel courseToUpdate)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEndpoint}")
                                                                   .AllowAnyHttpStatus()
                                                                   .PutJsonAsync(new
                                                                   {
                                                                       courseToUpdate = courseToUpdate
                                                                   })
                                                                   .ReceiveJson<BaseResponse<CourseViewModel>>();
            return response;
        }
    }
}
