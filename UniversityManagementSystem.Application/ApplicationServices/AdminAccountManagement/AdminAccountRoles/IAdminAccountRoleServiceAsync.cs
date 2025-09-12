using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.AdminAccountManagement.AdminAccountRoles;

namespace UniversityManagementSystem.Application.ApplicationServices.AdminAccountManagement.AdminAccountRoles
{
    public interface IAdminAccountRoleServiceAsync
    {
        Task<BaseResponse<AdminAccountRoleViewModel>> GetAllAdminAccountRolesByAdminAccountId(int adminAccountId);
        Task<BaseResponse<AdminAccountRoleViewModel>> CreateAdminAccountRole(AdminAccountRoleInputModel adminAccountRoleInputModel);
        Task<BaseResponse<AdminAccountRoleViewModel>> DeleteAdminAccountRole(int accountRoleId);
    }
}
