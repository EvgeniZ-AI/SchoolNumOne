using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNumOne
{
    public class assessment
    {
        public int id { get; set; }
        public int assessments { get; set; }
        public int studentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
