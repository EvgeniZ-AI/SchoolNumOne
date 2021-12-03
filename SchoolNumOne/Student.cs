using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNumOne
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int classId { get; set; }

        public virtual Class Class { get; set; }
        public virtual ICollection<assessment> Assessments { get; set; }
    }
}
