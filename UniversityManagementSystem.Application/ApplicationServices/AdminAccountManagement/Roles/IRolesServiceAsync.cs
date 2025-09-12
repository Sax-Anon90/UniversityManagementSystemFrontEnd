using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.AdminAccountManagement.Roles;

namespace UniversityManagementSystem.Application.ApplicationServices.AdminAccountManagement.Roles
{
    public interface IRolesServiceAsync
    {
        Task<BaseResponse<IEnumerable<RoleViewModel>>> GetAllRolesAsync();
    }
}
