using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    abstract class EducationalPerson
    {
        public string Name { get; set; }
        public string PersonalID { get; set; }
        public string OMId { get; set; }
        public string ClassLabel { get; set; }
        public int ClassLevel { get; set; }
    }
}
