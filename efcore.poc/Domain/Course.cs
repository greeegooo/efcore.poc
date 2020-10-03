using System.Collections;
using System.Collections.Generic;

namespace efcore.poc.Domain
{
    public class Course
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}