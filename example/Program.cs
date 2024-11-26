using System.Collections.Generic;

namespace example
{
    /*
     * készíts egy Osztályfőnok osztályt, tulajdonságok: név, OM, vane-e osztálya, 
     * osztály betűjele, évfolyam száma
     * */
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

        public HomeRoomTeacher(string name,  string omID,bool hasClass, string label, int level)
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
    class ClassRoom
    {
        //osztályfőnok
        HomeRoomTeacher Teacher;
        //terem
        string RoomNumber;
        //diák lista
        HashSet<Student> Students = new HashSet<Student>();
        public ClassRoom()
        {
        }

        public ClassRoom(HomeRoomTeacher teach, string roomnbr, HashSet<Student> diakok)
        {
            this.Teacher = teach;
            this.RoomNumber = roomnbr;
            this.Students = studentClassSelector(diakok);
        }

        //paraméternek megkap egy student listát, és visszatér egy listával ami ebbe az osztályba jár
        public HashSet<Student> studentClassSelector(HashSet<Student> studentsToSelectFrom)
        {
            HashSet<Student> selectedStudents = new HashSet<Student>();
            foreach (Student student in studentsToSelectFrom) 
            { 
                if(this.Teacher.isTheirHomeRomeTeacher(student))
                {
                    selectedStudents.Add(student);
                } 
            }
            return selectedStudents;
        }
        public override string ToString()
        {
            string roomproperties;

            roomproperties = "Home Room " + RoomNumber + ", Home Room Teacher: " + Teacher.Name;
            roomproperties  += "\nAktuális diák lista:\n";
            foreach (Student s in Students)
            {
                roomproperties += s.Name + "\n";
            }
            return roomproperties.Trim();

        }
    }
    class Student
    {
         public string Name { get; set; }
         public DateTime? DOB { get; set; }
         public string OMId { get; set; }
         public string ClassLabel { get; set; } = "C";
         public int ClassLevel { get; set; } = 12;

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
                   this.ClassLabel== otherStudent.ClassLabel;
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
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();
            Student student = new Student("jane doe12C", null, "123456", "C", 12);
            students.Add(student);
            Student student2 = new Student("john doe12C", null, "1234567", "C", 12);
            students.Add(student2);
            Student student3 = new Student("jane doe13C", null, "1234568", "C", 13);
            students.Add(student3);
            Student student4 = new Student("john doe13C", null, "1234569", "C", 13);
            students.Add(student4);
            /* Console.WriteLine("Aktuális diák lista: ");
             foreach (Student s in students)
             {
                 Console.WriteLine(s);
             }*/
            //Console.WriteLine("aktuális diák lista " + students);
            HomeRoomTeacher teach = new HomeRoomTeacher("Kiss Kános", "123456", true, "C", 12);
            ClassRoom classRoom = new ClassRoom(teach, "F115", students);
            Console.WriteLine(classRoom.ToString());
            // Console.WriteLine(student);
            // Console.WriteLine(student2);
            //  Console.WriteLine(student.isClassMate(student2));
            // Console.WriteLine(teach);
            // Console.WriteLine("Is " + teach.Name + " the homeschool teacher for " + student2.Name + 
            //    ": " + teach.isTheirHomeRomeTeacher(student2));
        }
    }
}
