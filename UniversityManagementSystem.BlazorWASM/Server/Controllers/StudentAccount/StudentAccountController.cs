using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementSystem.Application.ApplicationServices.StudentManagement.StudentAccounts;
using UniversityManagementSystem.Data.Models.StudentManagement.StudentAccounts;

namespace UniversityManagementSystem.BlazorWASM.Server.Controllers.StudentAccount
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAccountController : ControllerBase
    {
        private readonly IStudentAccountServiceAsync _studentAccountServiceAsync;
        public StudentAccountController(IStudentAccountServiceAsync _studentAccountServiceAsync)
        {
            this._studentAccountServiceAsync = _studentAccountServiceAsync;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudentAccounts()
        {
            return Ok(await _studentAccountServiceAsync.GetAllStudentAccountsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> RegisterStudentAccount(StudentAccountInputModel studentAccountToCreate)
        {
            return Ok(await _studentAccountServiceAsync.RegisterStudentAccountAsync(studentAccountToCreate));
        }

        [HttpGet("{studentAccountId}")]
        public async Task<IActionResult> GetStudentAccountById(int studentAccountId)
        {
            return Ok(await _studentAccountServiceAsync.GetStudentAccountByIdAsync(studentAccountId));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudentAccount([FromBody] StudentAccountUpdateModel studentAccountToUpdate)
        {
            return Ok(await _studentAccountServiceAsync.UpdateStudentAccountAsync(studentAccountToUpdate));
        }


        [HttpDelete("{studentAccountId}")]
        public async Task<IActionResult> DeleteStudentAccount(int studentAccountId)
        {
            return Ok(await _studentAccountServiceAsync.DeleteStudentAccountAsync(studentAccountId));
        }
    }
}
