using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.Authentication;

namespace UniversityManagementSystem.Application.ApplicationServices.Authentication
{
    public interface IAuthenticationServiceAsync
    {
        Task<BaseResponse<AuthUserResponse>> AuthenticateAsync(UserAuthDetailsModel authModel);
    }
}
