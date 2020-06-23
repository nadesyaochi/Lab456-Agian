using System.Linq;
using Lab456.Models;

namespace Lab456.Controllers
{
    internal class CoursesViewModel
    {
        public bool ShowAction { get; set; }
        public IQueryable<Course> UpcommingCourses { get; set; }
    }
}