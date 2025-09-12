using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.Courses;
using UniversityManagementSystem.Data.Models.CourseManagement.Courses;

namespace UniversityManagementSystem.BlazorWASM.Server.Controllers.Courses
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServiceAsync _courseServiceAsync;
        public CourseController(ICourseServiceAsync _courseServiceAsync)
        {
            this._courseServiceAsync = _courseServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            return Ok(await _courseServiceAsync.GetAllCoursesAsync());
        }

        [HttpGet("{courseCategoryId}")]
        public async Task<IActionResult> GetAllCoursesByCourseCategoryId(int courseCategoryId)
        {
            return Ok(await _courseServiceAsync.GetAllCoursesByCourseCategoryId(courseCategoryId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody] CourseInputModel courseToCreate) 
        {
            return Ok(await _courseServiceAsync.CreateCourseAsync(courseToCreate));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourse([FromBody] CourseUpdateModel courseToUpdate)
        {
            return Ok(await _courseServiceAsync.UpdateCourseAsync(courseToUpdate));
        }
    }
}
