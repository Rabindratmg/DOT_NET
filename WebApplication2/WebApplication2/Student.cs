namespace WebApplication2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }


        public List<Student> GetStudentInfo()
        {
            List<Student> students = new List<Student>()
            {
                new  Student{Id=1, Name="Student1", Age=23, Address="ktm"},
                new  Student{Id=2, Name="Student2", Age=24, Address="ktm"},
                new  Student{Id=3, Name="Student3", Age=25, Address="ktm"},
                new  Student{Id=4, Name="Student4", Age=26, Address="ktm"}
            };
            return students;

        }
    }
}
