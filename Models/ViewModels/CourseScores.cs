using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models.ViewModels
{
    public class CourseScores
    {
        public IEnumerable<Instructor>? Instructors  { get; set; }
        public IEnumerable<Course>? Courses { get; set; }
        public IEnumerable<Student>? Students { get; set; }
    }
}