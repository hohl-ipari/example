using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
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
                if (this.Teacher.isTheirHomeRomeTeacher(student))
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
            roomproperties += "\nAktuális diák lista:\n";
            foreach (Student s in Students)
            {
                roomproperties += s.Name + "\n";
            }
            return roomproperties.Trim();

        }
    }
}
