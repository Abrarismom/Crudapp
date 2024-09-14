using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crudapp.Models.Entities
{
    public class Employees
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
        [ForeignKey("DepartmentId")]
         public Guid DepartmentId { get; set; }

        [ForeignKey("DesignationId")]
        public Guid DesignationId { get; set; }

    }
    public class Designation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

      //  public ICollection<Designation> Designations { get; set; }

    }
        
        public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
      //  public ICollection<Department> Departments { get; set; }

    }

}
