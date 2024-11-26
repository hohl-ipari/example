using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Student: EducationalPerson
    {

        public DateTime? DOB { get; set; }

        public Student() { }
        /*
         * Készítsen egy paraméteres konstruktort
         */
        public Student(string name, DateTime? dob, string omID, string label, int level)
        {
            this.Name = name;
            this.DOB = dob;
            this.OMId = omID;
            this.ClassLabel = label;
            this.ClassLevel = level;
        }
        //ird felül a totString-et, hogy 
        public override string ToString()
        {
            return "A " + this.Name + " nevű tanuló a " + this.ClassLevel
                + this.ClassLabel + " osztályba jár.";
        }
        //osztalytars-e - paraméter egy másik diák, visszatérési érték logikai
        public bool isClassMate(Student otherStudent)
        {
            if (otherStudent == null)
            {
                return false;
            }
            return this.ClassLevel == otherStudent.ClassLevel &&
                   this.ClassLabel == otherStudent.ClassLabel;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Student))
            {
                return false;
            }

            // (Customer)obj;
            return this.OMId == ((Student)obj).OMId;
        }

        public override int GetHashCode()
        {
            return OMId.GetHashCode();
        }

    };
}
