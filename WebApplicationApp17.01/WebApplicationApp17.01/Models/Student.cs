using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationApp17._01.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
       public string LastName { get; set; }
        public string Email { get; set; }
        
    }
    public class StudentData
    {
        private static readonly List<Student> Students = new List<Student>();

        static StudentData()
        {
           Students.Add(new Student {Id=1, FirstName="Cristi", LastName="Popescu", Email="cristi@yahoo.com"});
           Students.Add(new Student { Id = 2, FirstName = "Gabi", LastName= "Ionescu", Email = "gabin@yahoo.com" });
           Students.Add(new Student { Id = 3, FirstName = "Costel", LastName = "Popa", Email = "cost@yahoo.com" });
           Students.Add(new Student { Id = 4, FirstName = "Mimi", LastName = "Ionascu", Email = "mimi@yahoo.com" });
            Students.Add(new Student { Id = 5, FirstName = "Claudiu", LastName = "Popica", Email = "clau@yahoo.com" });
            Students.Add(new Student { Id = 6, FirstName = "Gabi", LastName = "Ion", Email = "gabi@yahoo.com" });

        }
        public StudentData()
        {
        }
        public List<Student> GetStudents()
        {
            return Students;
        }

        public Student GetStudent(int id)
        {
            return Students.Find(x => x.Id == id);
        }
    }
}