using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.ApiLayer.BaseApiServiceConfig;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseCategory;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.CourseCategory;
using UniversityManagementSystem.Data.Models.CourseManagement.Courses;

namespace UniversityManagementSystem.ApiLayer.ApiServices.CourseManagement.CourseCategory
{
    public class CourseCategoryServiceAsync : ICourseCategoryService
    {
        private readonly ApiServiceConfig _apiServiceConfig;

        public CourseCategoryServiceAsync(ApiServiceConfig _apiServiceConfig)
        {
            this._apiServiceConfig = _apiServiceConfig;
        }
        public async Task<BaseResponse<CourseCategoryViewModel>> CreateCourseCategoryAsync(CourseCategoryInputModel courseCategoryToCreate)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseCategoryEndpoint}")
                                                                  .AllowAnyHttpStatus()
                                                                  .PostJsonAsync(new
                                                                  {
                                                                      courseCategoryToCreate = courseCategoryToCreate
                                                                  })
                                                                  .ReceiveJson<BaseResponse<CourseCategoryViewModel>>();
            return response;
        }

        public async Task<BaseResponse<IEnumerable<CourseCategoryViewModel>>> GetAllCourseCategoriesAsync()
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseCategoryEndpoint}")
                                                                  .AllowAnyHttpStatus()
                                                                  .GetJsonAsync<BaseResponse<IEnumerable<CourseCategoryViewModel>>>();
            return response;
        }

        public async Task<BaseResponse<CourseCategoryViewModel>> GetCourseByCourseCategory(int courseCategoryId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseCategoryEndpoint}/{courseCategoryId}")
                                                                  .AllowAnyHttpStatus()
                                                                  .GetJsonAsync<BaseResponse<CourseCategoryViewModel>>();
            return response;
        }

        public async Task<BaseResponse<CourseCategoryViewModel>> UpdateCourseCategoryAsync(CourseCategoryUpdateModel courseCategoryToUpdate)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseCategoryEndpoint}")
                                                                  .AllowAnyHttpStatus()
                                                                  .PostJsonAsync(new
                                                                  {
                                                                      courseCategoryToUpdate = courseCategoryToUpdate
                                                                  })
                                                                  .ReceiveJson<BaseResponse<CourseCategoryViewModel>>();
            return response;
        }

        public async Task<BaseResponse<CourseCategoryViewModel>> DeleteCourseCategoryAsync(int courseCategoryId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseCategoryEndpoint}/{courseCategoryId}")
                                                                  .AllowAnyHttpStatus()
                                                                  .DeleteAsync()
                                                                  .ReceiveJson<BaseResponse<CourseCategoryViewModel>>();
            return response;
        }

        
    }
}
