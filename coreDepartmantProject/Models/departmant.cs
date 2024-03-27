using System.ComponentModel.DataAnnotations;

namespace coreDepartmantProject.Models
{
    public class departmant
    { 

        [Key]
        public int deptid { get; set; }
        public string deptname { get; set; }
        public List<personal> personals { get; set; } // Burada List dememizin sebebi, bir departmanda birden çok çalışan çalışabilir. Bu yüzden list kullandık.

    }
}
