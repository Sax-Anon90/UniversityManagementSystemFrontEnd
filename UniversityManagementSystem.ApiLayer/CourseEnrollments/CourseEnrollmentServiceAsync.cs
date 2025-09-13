using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.ApiLayer.BaseApiServiceConfig;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseEnrollments;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.CourseEnrollments;
using UniversityManagementSystem.Data.Models.StudentManagement.StudentAccounts;

namespace UniversityManagementSystem.ApiLayer.CourseEnrollments
{
    public class CourseEnrollmentServiceAsync : ICourseEnrollmentServiceAsync
    {
        private readonly ApiServiceConfig _apiServiceConfig;
        public CourseEnrollmentServiceAsync(ApiServiceConfig _apiServiceConfig)
        {
            this._apiServiceConfig = _apiServiceConfig;
        }
        public async Task<BaseResponse<CourseEnrollmentViewModel>> CreateCourseEnrollmentAsync(CourseEnrollmentInputModel courseEnrollmentToCreate)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEnrollmentEndpoint}")
                                                                    .AllowAnyHttpStatus()
                                                                    .PostJsonAsync(new
                                                                    {
                                                                        courseEnrollmentToCreate = courseEnrollmentToCreate
                                                                    })
                                                                    .ReceiveJson<BaseResponse<CourseEnrollmentViewModel>>();
            return response;
        }

        public async Task<BaseResponse<CourseEnrollmentViewModel>> DeleteCourseEnrollmentAsync(int courseEnrollmentId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEnrollmentEndpoint}/{courseEnrollmentId}")
                                                                .AllowAnyHttpStatus()
                                                                .DeleteAsync()
                                                                .ReceiveJson<BaseResponse<CourseEnrollmentViewModel>>();
            return response;
        }

        public async Task<BaseResponse<IEnumerable<CourseEnrollmentViewModel>>> GetAllStudentCourseEnrollmentsByStudentIdAsync(int studentId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.CourseEnrollmentEndpoint}/{studentId}")
                                                                  .AllowAnyHttpStatus()
                                                                  .GetJsonAsync<BaseResponse<IEnumerable<CourseEnrollmentViewModel>>>();
            return response;
        }
    }
}
