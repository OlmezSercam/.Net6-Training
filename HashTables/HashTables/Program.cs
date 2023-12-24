using System;
using System.Collections;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            Student stud1 = new Student(1, "Sercan", 98);
            Student stud2 = new Student(2, "Ercan", 96);
            Student stud3 = new Student(3, "Mert", 78);
            Student stud4 = new Student(4, "Ali", 90);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            //retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            //retrieve all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student Id:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA{0}", temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student Id:{0}", value.Id);
                Console.WriteLine("Student Name:{0}", value.Name);
                Console.WriteLine("Student GPA{0}", value.GPA);
            }
            Console.WriteLine("Student ID:{0}, Name: {1}, Gpa{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
        }  
    }



    class Student
    {
        //property called id
        public int Id { get; set; }
        //property called Name
        public string Name { get; set; }
        //property called GPA
        public float GPA { get; set; }
        //simple constructor
        public Student(int id, string name, float gPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gPA;
        }
    }
}
