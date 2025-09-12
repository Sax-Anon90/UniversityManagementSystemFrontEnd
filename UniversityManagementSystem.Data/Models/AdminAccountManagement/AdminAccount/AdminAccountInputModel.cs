using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Data.Models.AdminAccountManagement.AdminAccount
{
    public class AdminAccountInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public string AdminEmail { get; set; }
        public string Password { get; set; }
    }
}
