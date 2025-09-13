using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.ApiLayer.ApiServices.Authentication;
using UniversityManagementSystem.ApiLayer.ApiServices.CourseManagement.CourseCategory;
using UniversityManagementSystem.ApiLayer.ApiServices.CourseManagement.CourseEnrollments;
using UniversityManagementSystem.ApiLayer.ApiServices.CourseManagement.Courses;
using UniversityManagementSystem.ApiLayer.BaseApiServiceConfig;
using UniversityManagementSystem.ApiLayer.StudentManagement.StudentAccounts;
using UniversityManagementSystem.Application.ApplicationServices.Authentication;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseCategory;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.CourseEnrollments;
using UniversityManagementSystem.Application.ApplicationServices.CourseManagement.Courses;
using UniversityManagementSystem.Application.ApplicationServices.StudentManagement.StudentAccounts;

namespace UniversityManagementSystem.ApiLayer.ApiServiceRegistration
{
    public static class ApiServiceRegistration
    {
        public static IServiceCollection AddApiLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ApiServiceConfig>();

            services.AddTransient<ICourseServiceAsync, CourseServiceAsync>();
            services.AddTransient<ICourseCategoryService, CourseCategoryServiceAsync>();
            services.AddTransient<ICourseEnrollmentServiceAsync, CourseEnrollmentServiceAsync>();
            services.AddTransient<IAuthenticationServiceAsync, AuthenticationServiceAsync>();
            services.AddTransient<IStudentAccountServiceAsync, StudentAccountServiceAsync>();


            return services;
        }
    }
}
