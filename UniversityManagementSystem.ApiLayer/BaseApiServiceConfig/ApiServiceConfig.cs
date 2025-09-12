using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.ApiLayer.BaseApiServiceConfig
{
    public class ApiServiceConfig(IConfiguration _configuration)
    {
        private readonly IConfiguration _configuration = _configuration;

        public string BaseUri { get; private set; } = _configuration["ApiService:BaseUri"]?.ToString() ?? string.Empty;
        public string AdminAccountEndpoint { get; private set; } = _configuration["ApiService:AdminAccountEndpoint"]?.ToString() ?? string.Empty;
        public string AdminAccountRoleEndpoint { get; private set; } = _configuration["ApiService:AdminAccountRoleEndpoint"]?.ToString() ?? string.Empty;
        public string AuthenticationEndpoint { get; private set; } = _configuration["ApiService:AuthenticationEndpoint"]?.ToString() ?? string.Empty;
        public string CourseEndpoint { get; private set; } = _configuration["ApiService:CourseEndpoint"]?.ToString() ?? string.Empty;
        public string CourseCategoryEndpoint { get; private set; } = _configuration["ApiService:CourseCategoryEndpoint"]?.ToString() ?? string.Empty;
        public string CourseEnrollmentEndpoint { get; private set; } = _configuration["ApiService:CourseEnrollmentEndpoint"]?.ToString() ?? string.Empty;
        public string RoleEndpoint { get; private set; } = _configuration["ApiService:RoleEndpoint"]?.ToString() ?? string.Empty;
        public string StudentAccountEndpoint { get; private set; } = _configuration["ApiService:StudentAccountEndpoint"]?.ToString() ?? string.Empty;

    }
}
