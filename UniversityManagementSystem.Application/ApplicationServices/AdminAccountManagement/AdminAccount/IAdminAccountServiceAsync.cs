using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.AdminAccountManagement.AdminAccount;

namespace UniversityManagementSystem.Application.ApplicationServices.AdminAccountManagement.AdminAccount
{
    public interface IAdminAccountServiceAsync
    {
        Task<BaseResponse<IEnumerable<AdminAccountViewModel>>> GetAllAdminAccountsAsync();
        Task<BaseResponse<AdminAccountViewModel>> RegisterAdminAccountAsync(AdminAccountInputModel adminAccountToCreate);
        Task<BaseResponse<AdminAccountViewModel>> UpdateAdminAccountAsync(AdminAccountUpdateModel adminAccountToUpdate);

    }
}
