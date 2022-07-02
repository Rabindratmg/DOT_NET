using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Branch {  get; set; }

        public void GetAllStudents()
        {
            List<Student> studentList = new List<Student>  { new Student { Id = 1, Name = "Rabindra", Age = 20, Gender="Male", Branch="CSIT" },
                                                               new Student { Id = 2, Name = "Nitesh", Age = 23, Gender = "Male", Branch="BCA"},
                                                               new Student { Id = 3, Name = "Rojina", Age = 24, Gender = "Female", Branch="BBA"},
                                                               new Student { Id = 4, Name = "Rizu", Age = 21, Gender = "Female", Branch="BIT"},
                                                               new Student { Id = 5, Name = "simran", Age = 20, Gender = "Female", Branch="MIT"}
                };

            var result = from student in studentList where student.Branch == "CSIT" & student.Age==20  select  student;

            foreach(var res in result)
            {
                Console.WriteLine("Name = {res.Name} Branch = {res.Branch} Gender = {res.Gender}");

            }




        }

    }
}
