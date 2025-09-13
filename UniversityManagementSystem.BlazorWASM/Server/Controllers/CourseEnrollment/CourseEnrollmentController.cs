using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseEnrollments;
using UniversityManagementSystem.Data.Models.CourseManagement;
using UniversityManagementSystem.Data.Models.CourseManagement.CourseEnrollments;

namespace UniversityManagementSystem.BlazorWASM.Server.Controllers.CourseEnrollment
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseEnrollmentController : ControllerBase
    {
        private readonly ICourseEnrollmentServiceAsync _courseEnrollmentServiceAsync;
        public CourseEnrollmentController(ICourseEnrollmentServiceAsync _courseEnrollmentServiceAsync)
        {
            this._courseEnrollmentServiceAsync = _courseEnrollmentServiceAsync;
        }
        [HttpGet("{studentAccountId}")]
        public async Task<IActionResult> GetCourseEnrollmentsByStudentId(int studentAccountId)
        {
            return Ok(await _courseEnrollmentServiceAsync.GetAllStudentCourseEnrollmentsByStudentIdAsync(studentAccountId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourseEnrollment(CourseEnrollmentInputModel courseEnrollmentToCreate)
        {
            return Ok(await _courseEnrollmentServiceAsync.CreateCourseEnrollmentAsync(courseEnrollmentToCreate));
        }

        [HttpDelete("{courseEnrollmentId}")]
        public async Task<IActionResult> DeleteCourseEnrollment(int courseEnrollmentId)
        {
            return Ok(await _courseEnrollmentServiceAsync.DeleteCourseEnrollmentAsync(courseEnrollmentId));
        }
    }
}
