using LabTwo.Models.Students;

namespace LabTwo.Models.Groups
{
    public class Group
    {
        private string itsName;
        private List<Student> itsStudents;

        public string Name { get { return itsName; } set { itsName = value; } }
        public List<Student> Students { get { return itsStudents; } set { itsStudents = value; } }

        public Group() 
        {
            itsName = string.Empty;
            itsStudents = new List<Student>(); 
        }
        public Group(List<Student> students)
        {
            itsStudents = students;
        }

        public void AddStudent(Student student)
        {
            itsStudents.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            itsStudents.Remove(student);
        }
    }
}