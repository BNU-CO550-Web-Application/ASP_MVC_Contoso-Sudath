using ASP_MVC_Contoso.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_MVC_Contoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string CodeCode { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
