using LabTwo.Models.Subjects;

namespace LabTwo.Models.Department
{
    public class Department : IEquatable<Department>
    {
        private string itsDepartmentName;
        private List<Subject> itsSubjects;

        public string Name { get { return itsDepartmentName; } set { itsDepartmentName = value; } }
        public List<Subject> Subjects { get { return itsSubjects; } set { itsSubjects = value; } }

        public Department()
        {
            itsDepartmentName = string.Empty;
            itsSubjects = null;
        }
        public Department(string departmentName, List<Subject> subjects)
        {
            itsDepartmentName = departmentName;
            itsSubjects = subjects;
        }


        public bool Equals(Department rhs)
        {
            return itsDepartmentName == rhs.itsDepartmentName && itsSubjects.Equals(rhs.itsSubjects);
        }
    }
}