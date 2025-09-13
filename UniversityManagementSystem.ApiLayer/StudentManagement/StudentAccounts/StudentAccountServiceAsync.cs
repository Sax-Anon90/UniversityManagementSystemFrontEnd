using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.ApiLayer.BaseApiServiceConfig;
using UniversityManagementSystem.Application.ApplicationServices.StudentManagement.StudentAccounts;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.CourseManagement.Courses;
using UniversityManagementSystem.Data.Models.StudentManagement.StudentAccounts;

namespace UniversityManagementSystem.ApiLayer.StudentManagement.StudentAccounts
{
    public class StudentAccountServiceAsync : IStudentAccountServiceAsync
    {
        private readonly ApiServiceConfig _apiServiceConfig;
        public StudentAccountServiceAsync(ApiServiceConfig _apiServiceConfig)
        {
            this._apiServiceConfig = _apiServiceConfig;
        }
        public async Task<BaseResponse<StudentAccountViewModel>> DeleteStudentAccountAsync(int studentAccountId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.StudentAccountEndpoint}/{studentAccountId}")
                                                                 .AllowAnyHttpStatus()
                                                                 .DeleteAsync()
                                                                 .ReceiveJson<BaseResponse<StudentAccountViewModel>>();
            return response;
        }

        public async Task<BaseResponse<IEnumerable<StudentAccountViewModel>>> GetAllStudentAccountsAsync()
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.StudentAccountEndpoint}")
                                                                 .AllowAnyHttpStatus()
                                                                 .GetJsonAsync<BaseResponse<IEnumerable<StudentAccountViewModel>>>();
            return response;
        }

        public async Task<BaseResponse<StudentAccountViewModel>> GetStudentAccountByIdAsync(int studentAccountId)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.StudentAccountEndpoint}")
                                                                  .AllowAnyHttpStatus()
                                                                  .GetJsonAsync<BaseResponse<StudentAccountViewModel>>();
            return response;
        }

        public async Task<BaseResponse<StudentAccountViewModel>> RegisterStudentAccountAsync(StudentAccountInputModel studentAccountToCreate)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.StudentAccountEndpoint}")
                                                                   .AllowAnyHttpStatus()
                                                                   .PostJsonAsync(new
                                                                   {
                                                                       studentAccountToCreate = studentAccountToCreate
                                                                   })
                                                                   .ReceiveJson<BaseResponse<StudentAccountViewModel>>();
            return response; 
        }

        public async Task<BaseResponse<StudentAccountViewModel>> UpdateStudentAccountAsync(StudentAccountUpdateModel studentAccountToUpdate)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.StudentAccountEndpoint}")
                                                                   .AllowAnyHttpStatus()
                                                                   .PutJsonAsync(new
                                                                   {
                                                                       studentAccountToUpdate = studentAccountToUpdate
                                                                   })
                                                                   .ReceiveJson<BaseResponse<StudentAccountViewModel>>();
            return response;
        }
    }
}
