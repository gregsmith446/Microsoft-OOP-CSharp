using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySelfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTATIATE EACH OBJECT: student, teacher, Uprogram

            // Instantiate a UProgram object called Business.
            UProgram newProgram = new UProgram("Information Technology");

            // Instantiate a Degree object, such as Bachelor, inside the UProgram object.
            Degree newDegree = new Degree("Bachelor");
            newProgram.degrees[0] = newDegree; / /Bachelor degree in 'IT program' located at index 0

            // Instantiate a Course object called 'Programming with C#' inside the Degree object.
            Course newCourse = new Course("Programming with C#");
            newDegree.courses[0] = newCourse;

            // Instantiate three students in this Course object.
            Student student0 = new Student("harry", 4, "smith");
            Student student1 = new Student("sally', 2, "jones");
            Student student2 = new Student("john", 3, "mcDonald");
            // set the student equal to respective student
            newCourse.students[0] = student0;
            newCourse.students[1] = student1;
            newCourse.students[2] = student2;
            int studentCount = Student.CountStudents();

            // Instantiate at least one Teacher object in the Course object
            var teacher0 = new Teacher("Dr. Manafort", 45, "Design Patters");
            newCourse.teachers[0] = teacher0;

            // Using Console.WriteLine statements, output the following information to the console window:
            
            // The name of the program and the degree it contains
            Console.WriteLine("The program name is {0} and it contains a {1}'s Degree", newProgram.UProgramName, newProgram.degrees[0].DegreeName);
            // The name of the course in the degree
            Console.WriteLine("The name of the course in this degree is {0}", newDegree.courses[0].CourseName);
            // The count of the number of students in the course.
            Console.WriteLine("The number of students in this course are: {0}.", studentCount);
            
            
            // Experimenting with the other items to print
            Console.WriteLine("Two students are: {0}, who lives in {1}. And {2}, who is in year {3}", newCourse.students[0].name, newCourse.students[0].dorm, newCourse.students[1].name, newCourse.students[1].Year);
            Console.WriteLine("Their teacher is {0}, who teaches them {1}", newCourse.teachers[0].name, newCourse.teachers[0].classTaught);

        }
    }
}