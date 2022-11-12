using LabTwo.Models.Students;

namespace LabTwo.Models.Workers.Teachers
{
    public class Teacher : Worker, IEquatable<Teacher>
    {
        private ScientificTitle itsScientificTitle;
        private List<Student> itsStudents;

        public ScientificTitle ScientificTitle { get { return itsScientificTitle; } set { itsScientificTitle = value; } }
        public List<Student> Students { get { return itsStudents; } set { itsStudents = value; } }
        
        public Teacher()
        {
            itsScientificTitle = ScientificTitle.UsualTeacher;
            itsStudents = null;
        }
        public Teacher(string name, int age, double salary, ScientificTitle scientificTitle, List<Student> students) 
            : base(name, age, salary)
        {
            itsScientificTitle = scientificTitle;
            itsStudents = students;
        }

        public bool AddStudent(Student student) 
        {
            if (itsStudents.Count < 10)
            {
                itsStudents.Add(student);
                return true;
            }
            else
                return false;
        }
        public void RemoveStudent(Student student)
        {
            itsStudents.Remove(student);
        }


        public bool Equals(Teacher rhs)
        {
            return itsName == rhs.itsName && itsAge == rhs.itsAge && itsSalary == rhs.itsSalary
                && itsScientificTitle == rhs.itsScientificTitle && itsStudents.Equals(rhs);
        }
    }
}