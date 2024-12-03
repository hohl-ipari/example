using System.Collections.Generic;

namespace example
{
    /*
     * készíts egy Osztályfőnok osztályt, tulajdonságok: név, OM, vane-e osztálya, 
     * osztály betűjele, évfolyam száma
     * */

   
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
