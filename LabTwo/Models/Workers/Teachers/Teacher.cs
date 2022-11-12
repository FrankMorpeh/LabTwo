using LabTwo.Models.Students;

namespace LabTwo.Models.Workers.Teachers
{
    public class Teacher : Worker
    {
        private List<Student> itsStudents;

        public List<Student> Students { get { return itsStudents; } set { itsStudents = value; } }
        
        public Teacher()
        {
            itsStudents = null;
        }
        public Teacher(string name, int age, double salary, List<Student> students) : base(name, age, salary)
        {
            itsStudents = students;
        }
    }
}