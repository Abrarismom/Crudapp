using Crudapp.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crudapp.Models
{
    public class AddEmployeeViewModel
    {
        
        public string Name { get; set; }
        public string? Email { get; set;}
        public string Phone { get; set; }
        public Guid DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public Guid DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }
    }
}
