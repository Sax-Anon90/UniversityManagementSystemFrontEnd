using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseCategory;
using UniversityManagementSystem.Data.Models.CourseManagement.CourseCategory;

namespace UniversityManagementSystem.BlazorWASM.Server.Controllers.CourseCategory
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController : ControllerBase
    {
        private readonly ICourseCategoryService _courseCategoryService;
        public CourseCategoryController(ICourseCategoryService _courseCategoryService)
        {
            this._courseCategoryService = _courseCategoryService;   
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourseCategories()
        {
            return Ok(await _courseCategoryService.GetAllCourseCategoriesAsync());
        }

        [HttpGet("{courseCategoryId}")]
        public async Task<IActionResult> GetAllCourseCategories(int courseCategoryId)
        {
            return Ok(await _courseCategoryService.GetCourseByCourseCategoryId(courseCategoryId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourseCategory([FromBody] CourseCategoryInputModel courseCategoryToCreate)
        {
            return Ok(await _courseCategoryService.CreateCourseCategoryAsync(courseCategoryToCreate));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourseCategory([FromBody] CourseCategoryUpdateModel courseCategoryToUpdate)
        {
            return Ok(await _courseCategoryService.UpdateCourseCategoryAsync(courseCategoryToUpdate));
        }
    }
}
