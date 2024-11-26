using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class HomeRoomTeacher
    {
        public string Name { get; set; }
        public string OMId { get; set; }
        public bool HasClass { get; set; }
        public string ClassLabel { get; set; }
        public int ClassLevel { get; set; }
        //írj default és paraméteres kostruktort
        public HomeRoomTeacher()
        {
        }

        public HomeRoomTeacher(string name, string omID, bool hasClass, string label, int level)
        {
            this.Name = name;
            this.OMId = omID;
            this.HasClass = hasClass;
            this.ClassLabel = label;
            this.ClassLevel = level;
        }

        public override string ToString()
        {
            return "A " + this.Name + " nevű tanár a " + this.ClassLevel
                + this.ClassLabel + " osztály osztályfőnöke.";
        }

        //osztalyfökök-e - paraméter egy diák, visszatérési érték logikai
        public bool isTheirHomeRomeTeacher(Student otherStudent)
        {
            if (otherStudent == null)
            {
                return false;
            }
            if (!this.HasClass)
            {
                return false;
            }
            return this.ClassLevel == otherStudent.ClassLevel &&
                   this.ClassLabel == otherStudent.ClassLabel;
        }
    }
}
