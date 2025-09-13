using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Application.Common;
using UniversityManagementSystem.Data.Models.StudentManagement.StudentAccounts;

namespace UniversityManagementSystem.Application.ApplicationServices.StudentManagement.StudentAccounts
{
    public interface IStudentAccountServiceAsync
    {
        Task<BaseResponse<IEnumerable<StudentAccountViewModel>>> GetAllStudentAccountsAsync();
        Task<BaseResponse<StudentAccountViewModel>> RegisterStudentAccountAsync(StudentAccountInputModel studentAccountToRegister);
        Task<BaseResponse<StudentAccountViewModel>> GetStudentAccountByIdAsync(int studentAccountId);
        Task<BaseResponse<StudentAccountViewModel>> UpdateStudentAccountAsync(StudentAccountUpdateModel studentAccountToUpdate);
        Task<BaseResponse<StudentAccountViewModel>> DeleteStudentAccountAsync(int studentAccountId);
    }
}

