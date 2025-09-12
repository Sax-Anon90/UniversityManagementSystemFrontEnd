using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Data.Common;

namespace UniversityManagementSystem.Data.Models.AdminAccountManagement.Roles
{
    public class RoleViewModel : AuditFields
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
