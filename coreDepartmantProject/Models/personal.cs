using System.ComponentModel.DataAnnotations;

namespace coreDepartmantProject.Models
{
    public class personal
    {
        [Key]
        public int personalid { get; set; }
        public string personalname{ get; set; }
        public string personallastname { get; set; }
        public string personalsehir { get; set; }

        public  departmant depart { get; set; }
    }
}
