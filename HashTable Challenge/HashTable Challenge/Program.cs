using System;
using System.Collections;

namespace HashTable_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            
            
            
            Student[] students = new Student[5];
            students[0] = new Student(1, "Sercan", 88);
            students[1] = new Student(2, "Ercan", 98);
            students[2] = new Student(3, "Mert", 50);
            students[3] = new Student(1, "Mami", 90);
            students[4] = new Student(5, "Ali", 70);

            foreach (Student student in students)
            {
                if (!table.ContainsKey(student.Id))
                {
                    table.Add(student.Id, student);
                    Console.WriteLine("Student with ID{0} added" , student.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, A student with this ID already exists ID:{0}",student.Id);
                }
            }

            
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            Id = id;
            Name = name;
            GPA = GPA;
        }
    }
}
