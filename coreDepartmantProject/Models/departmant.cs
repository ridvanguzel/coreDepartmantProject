using System.ComponentModel.DataAnnotations;

namespace coreDepartmantProject.Models
{
    public class departmant
    { 

        [Key]
        public int deptid { get; set; }
        public string deptname { get; set; }
    }
}
