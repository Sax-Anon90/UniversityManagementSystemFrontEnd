using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.ApiLayer.BaseApiServiceConfig;
using UniversityManagementSystem.Application.ApplicationServices.Authentication;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.Authentication;
using UniversityManagementSystem.Data.Models.CourseManagement.Courses;

namespace UniversityManagementSystem.ApiLayer.ApiServices.Authentication
{
    public class AuthenticationServiceAsync : IAuthenticationServiceAsync
    {
        private readonly ApiServiceConfig _apiServiceConfig;
        public AuthenticationServiceAsync(ApiServiceConfig _apiServiceConfig)
        {
            this._apiServiceConfig = _apiServiceConfig;
        }
        public async Task<BaseResponse<AuthUserResponse>> AuthenticateAsync(UserAuthDetailsModel authModel)
        {
            var response = await $"{_apiServiceConfig.BaseUri}".AppendPathSegment($"{_apiServiceConfig.AuthenticationEndpoint}")
                                                                  .AllowAnyHttpStatus()
                                                                  .PostJsonAsync(new
                                                                  {
                                                                      authModel = authModel
                                                                  })
                                                                  .ReceiveJson<BaseResponse<AuthUserResponse>>();
            return response;
        }
    }
}
