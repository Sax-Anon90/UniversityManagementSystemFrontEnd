using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Common;

namespace UniversityManagementSystem.Data.Models.StudentManagement.StudentAccounts
{
    public class StudentAccountViewModel : AuditFields
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudentNumber { get; set; }
        public bool IsActive { get; set; }
        public string StudentEmail { get; set; }
    }
}
